import {FC} from 'react'
import {Box, Link as ChakraLink, Text} from '@chakra-ui/react'
import {Link, useLocation} from 'react-router'

type SideBarProps = object

const SideBar: FC<SideBarProps> = () => {
  const location = useLocation()

  const menuItems = [
    {label: 'MAIN', to: '/main'},
    {label: 'PAGE1', to: '/pageone'},
    {label: 'PAGE2', to: '/pagetwo'}
  ]

  return (
    <Box w="100%" h="100%" bg="red.100">
      <Text pb="sm">THE SIDEBAR COMPONENT</Text>
      {menuItems.map((item, index) => {
        const isActive = location.pathname === item.to

        return (
          <Box key={index} bg={isActive ? 'blue.400' : 'blue.200'} w="80%" mb="2" p="2" borderRadius="md">
            <ChakraLink as={Link} to={item.to} style={{textDecoration: 'none'}}>
              <Text color="white" fontWeight={isActive ? 'bold' : 'normal'}>
                {item.label}
              </Text>
            </ChakraLink>
          </Box>
        )
      })}
    </Box>
  )
}

export default SideBar
