import {FC} from 'react'
import {Flex, Text} from '@chakra-ui/react'

const Footer: FC = () => {
  return (
    <Flex alignItems="center" justifyContent="center" p="1">
      <Text align="center" fontWeight="400" fontSize="xs">
        Made with ❤️ by the team
      </Text>
    </Flex>
  )
}

export default Footer
