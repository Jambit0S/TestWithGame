const express = require('express')

const generalUserRouter = require('./routerGeneral/general.routes')
const PORT = process.env.PORT || 8080

const app = express()
app.use(express.json())

app.use('/general',generalUserRouter)

app.listen(PORT,()=>console.log(`server start on port ${PORT}`))