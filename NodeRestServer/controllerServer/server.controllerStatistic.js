const db=require('../server')

class ServerStatsController
{
    async checkUserData(req,res)
    {
        
        const stats= await db.query(`SELECT * FROM statistic_theme`)
        res.json("nice")
    }
}