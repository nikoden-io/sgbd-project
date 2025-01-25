export interface IDemoGateway {
  getDemo(): Promise<string>

  transform(valueToTransform: string): Promise<string>
}
