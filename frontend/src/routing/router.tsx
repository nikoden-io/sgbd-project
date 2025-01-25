import {createBrowserRouter} from 'react-router'
import NotFound from '@/routing/NotFound'
import {AppStore} from '@lib/common/redux/create-store'
import RootLayout from '@ui/layout/RootLayout'
import {DemoMainPage} from 'src/ui/feature/demo'
import {DemoPageOne, DemoPageTwo} from '@ui/feature/demo'

export const createRouter = ({store}: {store: AppStore}, createRouterFn = createBrowserRouter) =>
  createRouterFn([
    {
      path: '/',
      element: <RootLayout />,
      children: [
        {
          index: true,
          element: <DemoMainPage />
        },
        {
          path: 'main',
          element: <DemoMainPage />
        },
        {
          path: 'pageone',
          element: <DemoPageOne />
        },
        {
          path: 'pagetwo',
          element: <DemoPageTwo />
        },
        {
          path: '*',
          element: <NotFound />
        }
      ]
    }
  ])

export type AppRouter = ReturnType<typeof createRouter>
