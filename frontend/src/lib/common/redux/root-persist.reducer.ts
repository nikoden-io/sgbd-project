import {persistReducer} from 'redux-persist'
import storage from 'redux-persist/lib/storage'
import {rootReducer} from '@lib/common/redux/root.reducers'

const persistConfig = {
  key: 'root',
  storage,
  blacklist: [],
  whitelist: ['demo']
  // transforms: [
  //   encryptTransform({
  //     secretKey: import.meta.env.VITE_REDUX_PERSIST_CRYPTO_KEY,
  //     onError: function (error) {
  //       console.error('Error encryptTransform:', error)
  //     }
  //   })
  // ]
}

export const persistedReducer = persistReducer(persistConfig, rootReducer)
