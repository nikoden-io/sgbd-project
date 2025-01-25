import {AnyAction, configureStore, createListenerMiddleware, ThunkDispatch} from '@reduxjs/toolkit'
import {FLUSH, PAUSE, PERSIST, PURGE, REGISTER, REHYDRATE} from 'redux-persist'

import {persistedReducer} from '@lib/common/redux/root-persist.reducer'

import {rootReducer} from './root.reducers'
import {IS_DEVTOOLS_REDUX_ACTIVE} from '@/env/env'
import {AxiosHttpClient} from '@lib/common/http-client/infrastructure/axios-http-client.gateway'
import {IDemoGateway} from '@features/demo/domain/IDemoGateway'
import {DemoImplGateway} from '@features/demo/infrastructure/demo-impl.gateway'

export const EMPTY_ARGS = 'EMPTY_ARGS' as const

export type Dependencies = {
  demoGateway: IDemoGateway
}

const listenerMiddleware = createListenerMiddleware()

export const createStore = (dependencies: Dependencies) => {
  return configureStore({
    devTools: IS_DEVTOOLS_REDUX_ACTIVE,
    reducer: persistedReducer,
    // @ts-ignore
    middleware(getDefaultMiddleware) {
      return getDefaultMiddleware({
        thunk: {
          extraArgument: dependencies
        },
        immutableCheck: false,
        serializableCheck: {
          ignoredActions: [FLUSH, REHYDRATE, PAUSE, PERSIST, PURGE, REGISTER]
        }
      }).prepend(listenerMiddleware.middleware)
    }
  })
}

const httpClient = new AxiosHttpClient()

export const createTestStore = ({demoGateway = new DemoImplGateway()}: Partial<Dependencies> = {}) => {
  const store = createStore({
    demoGateway
  })

  return store
}

type AppStoreWithGetActions = ReturnType<typeof createStore>
export type AppStore = Omit<AppStoreWithGetActions, 'getActions'>
export type RootState = ReturnType<typeof rootReducer>
export type AppDispatch = ThunkDispatch<RootState, Dependencies, AnyAction>
