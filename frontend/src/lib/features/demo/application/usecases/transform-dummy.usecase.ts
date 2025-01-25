import {createAppAsyncThunk} from '@lib/common/redux/create-app-async-thunk'
import {AppDispatch, Dependencies, RootState} from '@lib/common/redux/create-store'
import {setDummy} from '@features/demo/application/demo.slice'

export const transformDummy = createAppAsyncThunk<
  void,
  {dummy: string},
  {
    dispatch: AppDispatch
    state: RootState
    extra: Dependencies
    rejectValue: string
  }
>('demo/transformDummy', async ({dummy}, {extra: {demoGateway}, dispatch, rejectWithValue}) => {
  try {
    const transformedDummy = await demoGateway.transform(dummy)
    dispatch(setDummy(transformedDummy))
  } catch (error) {
    return rejectWithValue('Transformation failed')
  }
})
