const db= require('../server')

class GeneralControllerTest
{
    async getAllTests(req,res)
    {
        const tests = await db.query(`SELECT * FROM test`)
        res.json(tests.rows)
    }
    async getAllNamesTests(req,res)
    {
        const tests = await db.query(`SELECT name FROM test`)
        res.json(tests.rows)
    }
    async getOneTest(req,res)
    {
        const id=req.params.id
        const test = await db.query(`SELECT * FROM test where id=$1`,[id])
        res.json(test.rows[0])
    }
    async getAllTestLesson(req,res)
    {
        const lesson=req.params.lesson
        const tests=await db.query(`SELECT * FROM test where lesson_id=$1`,[lesson])
        res.json(tests.rows)
    }
}
module.exports = new GeneralControllerTest()