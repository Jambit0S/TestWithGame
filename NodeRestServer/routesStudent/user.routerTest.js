const Router = require('express')
const router = new Router()
const testControllerStudent = require('../controllerStudent/user.controllerTest')

router.get('/test',testControllerStudent.getAllTests)
router.get('/test/name',testControllerStudent.getAllNamesTests)
router.get('/test/:id',testControllerStudent.getOneTest)


module.exports = router