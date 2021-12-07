const db= require('../server')

class GemeralControllerUser
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
    async getOneCustomizationUser(req,res)
    {
        const id=req.params.id
        const customization = await db.query(`SELECT * from myuser where id=$1`,[id])
        res.json(customization.rows[0].customization)
    }
}
module.exports = new GemeralControllerUser()