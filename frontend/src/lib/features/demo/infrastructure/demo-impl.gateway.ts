import {IDemoGateway} from '@features/demo/domain/IDemoGateway'

export class DemoImplGateway implements IDemoGateway {
  async getDemo() {
    return 'demo impl'
  }

  async transform(valueToTransform: string) {
    return `transformed ${valueToTransform}`
  }
}
