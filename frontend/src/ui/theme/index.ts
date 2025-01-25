import {extendTheme} from '@chakra-ui/react'

export type FontSizeProps = 'xxs' | 'xs' | 'sm' | 'md' | 'lg' | 'xl' | '2xl' | '3xl' | '4xl'
export type SpaceProps = 'xxs' | 'xs' | 'sm' | 'md' | 'lg' | 'xl' | '2xl' | '3xl' | '4xl'

const space = {
  xxs: '4px',
  xs: '8px',
  sm: '16px',
  md: '24px',
  lg: '32px',
  xl: '48px',
  '2xl': '64px',
  '3xl': '80px',
  '4xl': '96px'
}

const breakpoints = {
  xs: '30em', // 480px for mobile
  sm: '40em', // 640px for small tablets/large phones
  md: '52em', // 832px for tablets
  lg: '64em', // 1024px for desktops
  xl: '80em', // 1280px for larger desktops
  '2xl': '96em' // 1536px for extra large displays
}

const colors = {
  dom: {
    alert: '#ce0000',
    alertPale: 'rgba(206, 0, 0, 0.5)',
    bgGray: '#f8f8f8',
    layer0Bg: '#e7ecef',
    layer1Bg: '#f8f8f8',
    layer2Bg: 'rgba(20,20,20,0.03)',
    layer3Bg: '#f8f8f8',
    lightGray: '#d6d6d6',
    mainBlue: '#274c77',
    mainBluePale: 'rgba(39,76,119, 0.5)',
    pil: '#3271fa',
    purpleGray: '#3b3a47',
    secondaryGray: '#879CB3',
    success: '#439857',
    successPale: 'rgba(67,152,87, 0.5)',
    warning: '#fb9906',
    warningPale: 'rgba(251,53,6, 0.5)',
    white: '#f9f9f9'
  }
}

const fontSizes = {
  xxs: '0.625rem', // 10px
  xs: '0.75rem', // 12px
  sm: '0.875rem', // 14px
  md: '1rem', // 16px
  lg: '1.125rem', // 18px
  xl: '1.25rem', // 20px
  '2xl': '1.5rem', // 24px
  '3xl': '1.875rem', // 30px
  '4xl': '2.25rem', // 36px
  '5xl': '3rem', // 48px
  '6xl': '3.75rem' // 60px
}

const globalStyles = {
  global: {
    'html, body': {
      fontSize: '16px' // Base font size for rem calculations
    }
  }
}

const config = {
  colors,
  initialColorMode: 'light',
  fontSizes,
  space,
  styles: globalStyles,
  useSystemColorMode: false,
  components: {
    Heading: {
      baseStyle: (props: any) => ({
        color: props.colorMode === 'dark' ? 'whiteAlpha.700' : 'blackAlpha.700'
      })
    },
    Text: {
      baseStyle: (props: any) => ({
        color: props.colorMode === 'dark' ? 'whiteAlpha.700' : 'blackAlpha.700'
      })
    }
  }
}

const theme = extendTheme({...config, breakpoints})

export default theme
