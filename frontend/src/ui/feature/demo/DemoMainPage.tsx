import {FC} from 'react'
import {useAppDispatch, useAppSelector} from '@lib/common/redux/redux-hooks'
import {selectDemoDummy} from '@features/demo/application/demo.selectors'
import {Box, Button, Text} from '@chakra-ui/react'
import {setDummy} from '@features/demo/application/demo.slice'

const DemoMainPage: FC = () => {
  const dummyVariableInStateManager = useAppSelector(selectDemoDummy)

  const dispatch = useAppDispatch()

  const handleChangeDummyValue = () => {
    dispatch(setDummy('New Value' + Math.random().toString()))
  }

  return (
    <Box>
      <Text>MAIN DEMO PAGE</Text>
      <Text>The Content is: {dummyVariableInStateManager}</Text>
      <Button onClick={handleChangeDummyValue}>Change Dummy Value</Button>
    </Box>
  )
}

export default DemoMainPage
