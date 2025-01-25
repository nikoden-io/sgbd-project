import {ChakraProvider, localStorageManager} from '@chakra-ui/react'
import {Provider as ReduxProvider} from 'react-redux'

import {PersistGate} from 'redux-persist/integration/react'

import {AppStore} from '@lib/common/redux/create-store'
import theme from '@ui/theme'
import {RouterProvider} from 'react-router'
import {AppRouter} from '@/routing/router'

export const Provider = ({store, persistor, router}: {store: AppStore; persistor: any; router: AppRouter}) => (
  <ReduxProvider store={store}>
    <PersistGate persistor={persistor}>
      <ChakraProvider theme={theme} resetCSS portalZIndex={10} colorModeManager={localStorageManager}>
        <RouterProvider router={router} />
      </ChakraProvider>
    </PersistGate>
  </ReduxProvider>
)
