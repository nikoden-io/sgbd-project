import {IDemoGateway} from '@features/demo/domain/IDemoGateway'

export class DemoTestGateway implements IDemoGateway {
  async getDemo() {
    return 'demo test'
  }

  async transform(valueToTransform: string) {
    return `transformed ${valueToTransform}`
  }
}
