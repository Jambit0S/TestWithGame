const Router = require('express')
const router = new Router()
const generalControllerUser = require('../controllerGeneral/general.controllerUser')

router.post('/authorization',generalControllerUser.checkUserData)
router.get('/users/',generalControllerUser.getAllUsers)
router.get('/user/:id',generalControllerUser.getOneUser)
router.get('/user/customization/:id',generalControllerUser.getOneCustomizationUser)

const generalControllerTheme = require('../controllerGeneral/general.controllerTheme')
router.get('/theme',generalControllerTheme.getAllThemes)
router.get('/microtheme',generalControllerTheme.getMicroThemes)

const generalControllerTest = require('../controllerGeneral/general.controllerTest')
router.get('/test',generalControllerTest.getAllTests)
router.get('/test/name',generalControllerTest.getAllNamesTests)
router.get('/test/:id',generalControllerTest.getOneTest)

const generalControllerQuestion= require('../controllerGeneral/general.controllerQuestion')
router.get('/question',generalControllerQuestion.getAllQuestions)
router.get('/question/:id',generalControllerQuestion.getOneQuestion)


module.exports = router