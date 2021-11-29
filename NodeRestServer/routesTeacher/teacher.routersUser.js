const Router = require('express')
const router = new Router()
const userControllerTeacher = require('../controllerTeacher/teachher.controller')

router.post('/user',userControllerTeacher.checkUserData)
router.get('/user/:id',userControllerTeacher.getOneUser)
router.get('/theme',userControllerTeacher.getAllThemes)


module.exports = router