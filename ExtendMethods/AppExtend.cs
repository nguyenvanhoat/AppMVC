using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


namespace mvc.ExtendMethods
{
    public static class AppExtend
    {
        public static void AddStatusCodePages(this IApplicationBuilder app)
        {
            app.UseStatusCodePages(apperror =>{
                apperror.Run(async context =>{
                    var respone = context.Response;
                    var code = respone.StatusCode;
                    var content = @$"<html>
                    <head>
                        <meta charset = 'UTF-8'/>
                    </head>
                    <h1> Xảy ra lỗi!: {code} - {(HttpStatusCode)code} </h1>
                    </html>
                    ";
                    await respone.WriteAsync(content);
                });
            });
        }
    }
}