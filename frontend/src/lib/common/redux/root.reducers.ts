import {combineReducers} from '@reduxjs/toolkit'
import {DemoSlice} from '@features/demo/application/demo.slice'

export const rootReducer = combineReducers({
  demo: DemoSlice.reducer
})
