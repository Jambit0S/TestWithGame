const express = require('express')

const studentUserRouter=require('./routesStudent/user.routesUser')
const studentTestRouter=require('./routesStudent/user.routerTest')
const studentQuestionRouter=require('./routesStudent/user.routerQuestion')

const teacherUserRouter = require('./routesTeacher/teacher.routersUser')

const PORT = process.env.PORT || 8080

const app = express()
app.use(express.json())
app.use('/student',studentUserRouter)
app.use('/student',studentTestRouter)
app.use('/student',studentQuestionRouter)

app.use('/teacher',teacherUserRouter)

app.listen(PORT,()=>console.log(`server start on port ${PORT}`))