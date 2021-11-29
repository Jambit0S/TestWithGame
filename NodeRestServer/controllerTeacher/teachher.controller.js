const db= require('../server')

class TeacherUserController
{
    async checkUserData(req,res)
    {
        const {login,password} = req.body
        const checkData = await db.query(`SELECT * FROM myuser where (login=$1 AND password=$2)`,[login,password])
        if (checkData.rowCount>0)
            res.json("welcome "+checkData.rows[0].name)
        else
        {
            res.json("Not found")
        }
    }
    async getOneUser(req,res)
    {
        const id=req.params.id
        const user = await db.query(`SELECT * FROM myuser where id=$1`,[id])
        res.json(user.rows[0])
    }
    async getAllThemes(req,res)
    {
        const themes = await db.query(`SELECT * FROM theme`)
        res.json(themes.rows)
    }
    
}
module.exports = new TeacherUserController()