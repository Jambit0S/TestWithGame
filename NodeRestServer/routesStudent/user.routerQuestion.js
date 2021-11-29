const Router = require('express')
const router = new Router()
const questionControllerStudent = require('../controllerStudent/user.controllerQuestion')

router.get('/question',questionControllerStudent.getAllQuestions)
router.get('/question/:id',questionControllerStudent.getOneQuestion)


module.exports = router