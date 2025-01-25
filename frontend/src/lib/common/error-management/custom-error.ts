import {ErrorState} from '@lib/common/error-management/error.types'

export enum CustomError {
  API_ERROR = 'API_ERROR',
  BAD_REQUEST = 'BAD_REQUEST',
  FORBIDDEN = 'FORBIDDEN',
  INTERNAL_SERVER_ERROR = 'INTERNAL_SERVER_ERROR',
  MISSING_PARAMETER = 'MISSING_PARAMETER',
  NETWORK_ERROR = 'NETWORK_ERROR',
  NOT_FOUND = 'NOT_FOUND',
  UNKNOWN_ERROR = 'UNKNOWN_ERROR'
}

export enum HttpStatusCode {
  OK = 200,
  CREATED = 201,
  BAD_REQUEST = 400,
  UNAUTHORIZED = 401,
  FORBIDDEN = 403,
  NOT_FOUND = 404,
  INTERNAL_SERVER_ERROR = 500
}

export const createCustomError = (type: CustomError, message?: string): ErrorState => {
  return {
    type,
    message
  }
}

export const createErrorStateFromStatusCode = (statusCode: HttpStatusCode, message?: string): ErrorState => {
  switch (statusCode) {
    case HttpStatusCode.OK:
    case HttpStatusCode.CREATED:
      return {
        type: null,
        message: message ?? ''
      }
    case HttpStatusCode.BAD_REQUEST:
      return {
        type: CustomError.MISSING_PARAMETER,
        message: message ?? 'Bad request'
      }
    case HttpStatusCode.UNAUTHORIZED:
      return {
        type: CustomError.FORBIDDEN,
        message: message ?? 'Unauthorized'
      }
    case HttpStatusCode.NOT_FOUND:
      return {
        type: CustomError.NOT_FOUND,
        message: message ?? 'Not found'
      }
    case HttpStatusCode.INTERNAL_SERVER_ERROR:
      return {
        type: CustomError.INTERNAL_SERVER_ERROR,
        message: message ?? 'Internal server error'
      }
    default:
      return {
        type: CustomError.UNKNOWN_ERROR,
        message: message ?? 'An unknown error occurred'
      }
  }
}
