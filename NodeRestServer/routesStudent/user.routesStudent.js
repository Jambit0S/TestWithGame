const Router = require('express')
const router = new Router()
const userControllerStudent = require('../controllerStudent/user.controllerStudent')

router.post('/user',userControllerStudent.checkUserData)
router.get('/user/:id',userControllerStudent.getOneUser)
router.get('/user/customization/:id',userControllerStudent.getOneCustomizationUser)

module.exports = router