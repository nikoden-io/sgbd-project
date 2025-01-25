import {createSlice, PayloadAction} from '@reduxjs/toolkit'

type DemoSliceState = {
  dummy: string
  isDemoLoading: boolean
}

const initialState: DemoSliceState = {
  dummy: '',
  isDemoLoading: false
}

export const DemoSlice = createSlice({
  name: 'demo',
  initialState,
  reducers: {
    setDummy: (state, action: PayloadAction<string>) => {
      if (action.payload === '') return

      state.dummy = action.payload
    },
    setIsDemoLoading: (state, action: PayloadAction<boolean>) => {
      state.isDemoLoading = action.payload
    }
  }
})

export const {setDummy, setIsDemoLoading} = DemoSlice.actions
