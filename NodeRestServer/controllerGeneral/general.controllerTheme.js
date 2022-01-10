const db= require('../server')

class GemeralControllerTheme
{ 
    async getAllThemes(req,res)
    {
        const user = await db.query(`SELECT * FROM theme`)
        res.json(user.rows)
    }
    async getOneTheme(req,res)
    {
        const id=req.params.id
        const user = await db.query(`SELECT * FROM theme where id=$1`,[id])
        res.json(user.rows[0])

    }
    async getMicroThemes(req,res)
    {
        const theme = await db.query (`SELECT *FROM microtheme`)
        console.log(theme.fields)
        res.json(theme.rows)
    }
    
    
        
}
module.exports = new GemeralControllerTheme()