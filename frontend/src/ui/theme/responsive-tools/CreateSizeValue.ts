import {useBreakpointValue} from '@chakra-ui/react'

type BreakpointValues = {[key in 'base' | 'sm' | 'md' | 'lg' | 'xl' | '2xl']?: string}

const CreateSizeValue = (...sizes: Array<string | null>) => {
  const breakpoints: Array<'base' | 'sm' | 'md' | 'lg' | 'xl' | '2xl'> = ['base', 'sm', 'md', 'lg', 'xl', '2xl']
  let lastValidValue: string | undefined

  const values = sizes.reduce((acc, size, index) => {
    if (size) lastValidValue = size
    acc[breakpoints[index]] = lastValidValue as string
    return acc
  }, {} as BreakpointValues)

  return useBreakpointValue(values)
}

export default CreateSizeValue
