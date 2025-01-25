import {CustomError} from '@lib/common/error-management/custom-error'

export interface ErrorState {
  type: CustomError | null
  message?: string
}
