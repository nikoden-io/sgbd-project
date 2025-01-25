import axios, {AxiosRequestConfig} from 'axios'
import {HttpClient} from '../domain/http-client.gateway'
import {IS_DEV} from '@/env/env'

export class AxiosHttpClient implements HttpClient {
  async get<T = any>(url: string, config?: AxiosRequestConfig): Promise<T> {
    const response = await axios.get<T>(url, {withCredentials: true, ...config})
    return response.data
  }

  async post<T = any>(url: string, body?: any, config?: AxiosRequestConfig): Promise<T> {
    try {
      const response = await axios.post<T>(url, body, {withCredentials: true, ...config})
      return response.data
    } catch (error: any) {
      if (error.isAxiosError) {
        if (IS_DEV) {
          console.error('API Error Response:', error.response?.data)
        }
      }
      throw error
    }
  }

  async put<T = any>(url: string, body?: any, config?: AxiosRequestConfig): Promise<T> {
    try {
      const response = await axios.put<T>(url, body, {withCredentials: true, ...config})
      return response.data
    } catch (error: any) {
      if (error.isAxiosError) {
        if (IS_DEV) {
          console.error('API Error Response:', error.response?.data)
        }
      }
      throw error
    }
  }

  async delete<T = any>(url: string, config?: AxiosRequestConfig): Promise<T> {
    const response = await axios.delete<T>(url, {
      withCredentials: true,
      ...config
    })
    return response.data
  }
}
