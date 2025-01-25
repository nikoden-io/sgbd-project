import {FC, useEffect, useState} from 'react'
import {Box, Flex, Grid, GridItem, Text, useBreakpointValue, useColorModeValue} from '@chakra-ui/react'
import {Outlet} from 'react-router'
import {Footer, NavBar, SideBar} from '@ui/layout/index'

const RootLayout: FC = () => {
  const [isContentLoading, setIsContentLoading] = useState(true)
  const [isLayoutLoading, setIsLayoutLoading] = useState(true)

  // UI Layout
  const bgColor = useColorModeValue('dom.layer0Bg', 'gray.700')

  const templateAreas = useBreakpointValue({
    base: `
      "header"
      "nav"
      "main"
      "footer"
    `,
    xl: `
      "header header"
      "nav main"
      "nav footer"
      `
  })

  const gridTemplateRows = useBreakpointValue({
    base: '5vh  7vh 1fr 3vh',
    xl: '7vh 1fr 3vh'
  })

  const gridTemplateColumns = useBreakpointValue({
    base: '1fr',
    xl: '6vw 1fr',
    '2xl': '11vw 1fr'
  })

  const ContentNotAvailable: React.FC<{descriptionOne: string; descriptionTwo: string}> = ({
    descriptionOne,
    descriptionTwo
  }) => (
    <Flex
      width="100vw"
      height="100vh"
      bg="dom.layer0Bg"
      alignItems="center"
      justifyContent="center"
      flexDirection="column">
      <Text fontSize="lg" fontWeight="500" textAlign="center">
        {descriptionOne}
      </Text>
      <Text fontSize="md" fontWeight="100" textAlign="center" pb="sm">
        {descriptionTwo}
      </Text>
    </Flex>
  )

  useEffect(() => {
    if (templateAreas && gridTemplateRows) {
      setTimeout(() => {
        setIsLayoutLoading(false)
        setIsContentLoading(false)
      }, 50)
    }
  }, [templateAreas, gridTemplateRows])

  if (isContentLoading || isLayoutLoading)
    return <ContentNotAvailable descriptionOne="Bienvenue," descriptionTwo="Initialisation en cours" />

  return (
    <Box w="full" h="100vh" bg={bgColor} overflow="hidden">
      <Grid
        templateAreas={templateAreas}
        gridTemplateRows={gridTemplateRows}
        gridTemplateColumns={gridTemplateColumns}
        height="100%"
        color="blackAlpha.700"
        border="1px solid red"
        fontWeight="bold">
        <GridItem area={'header'} border="1px solid yellow">
          <NavBar />
        </GridItem>
        <GridItem
          area={'nav'}
          display="flex"
          justifyContent="center"
          alignItems="center"
          transition="opacity 0.3s ease-in-out"
          border="1px solid blue">
          <SideBar />
        </GridItem>
        <GridItem area="main" overflow="auto" border="1px solid purple">
          <Outlet />
        </GridItem>
        <GridItem area={'footer'} border="1px solid orange">
          <Footer />
        </GridItem>
      </Grid>
    </Box>
  )
}

export default RootLayout
