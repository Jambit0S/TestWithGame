const db= require('../server')

class generalControllerQuestion
{
    async getAllQuestions(req,res)
    {
        const questions = await db.query(`SELECT * FROM question_info`)
        res.json(questions.rows)
    }
    async getOneQuestion(req,res)
    {
        const id = req.params.id
        const question = await db.query(`SELECT * FROM question_info where id=$1`,[id])
        res.json(question.rows[0])
    }
    
}
module.exports = new generalControllerQuestion()