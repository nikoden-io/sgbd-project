export interface HttpClient {
  get<T = any>(url: string, config?: any): Promise<T>

  post<T = any>(url: string, body?: any, config?: any): Promise<T>

  put<T = any>(url: string, body?: any, config?: any): Promise<T>

  delete<T = any>(url: string, body?: any, config?: any): Promise<T>
}
