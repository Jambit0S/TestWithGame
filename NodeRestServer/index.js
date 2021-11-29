const express = require('express')

const studentUserRouter=require('./routesStudent/user.routesStudent')

const PORT = process.env.PORT || 8080

const app = express()
app.use(express.json())
app.use('/student',studentUserRouter)

app.listen(PORT,()=>console.log(`server start on port ${PORT}`))