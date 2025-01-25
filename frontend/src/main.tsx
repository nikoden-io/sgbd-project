import {StrictMode, Suspense} from 'react'
import {createRoot} from 'react-dom/client'
import './index.css'
import {createRouter} from '@/routing/router'
import {persistStore} from 'redux-persist'
import {AxiosHttpClient} from '@lib/common/http-client/infrastructure/axios-http-client.gateway'
import {createStore, Dependencies} from '@lib/common/redux/create-store'
import {Provider} from '@/Provider'
import {DemoImplGateway} from '@features/demo/infrastructure/demo-impl.gateway'

const httpClient = new AxiosHttpClient()

export const dependencies: Dependencies = {
  demoGateway: new DemoImplGateway()
}

export const store = createStore(dependencies)

const persistor = persistStore(store, null, () => {})
const router = createRouter({store})

createRoot(document.getElementById('root')!).render(
  <StrictMode>
    <Suspense fallback="loading">
      <Provider {...{store, persistor, router}} />
    </Suspense>
  </StrictMode>
)
