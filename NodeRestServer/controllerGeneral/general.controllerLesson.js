const db= require('../server')

class generalControllerLesson
{
    async getAllLessons(req,res)
    {
        const questions = await db.query(`SELECT * FROM lesson_object`)
        res.json(questions.rows)
    }
    async getOneLesson(req,res)
    {
        const id = req.params.id
        const question = await db.query(`SELECT * FROM lesson_object where id=$1`,[id])
        res.json(question.rows[0])
    }
    
}
module.exports = new generalControllerLesson()