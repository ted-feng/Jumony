﻿using Ivony.Html.Web;
using Ivony.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

/// <summary>
/// TestJumonyHandler 的摘要说明
/// </summary>
public class TestJumonyHandler : JumonyHandler
{

  public static ICachedResponse Render( HttpContextBase context, string virtualPath )
  {
    return Render( JumonyRequestRoute.CreateRequestContext( context, virtualPath ) );
  }


  public static ICachedResponse Render( RequestContext context )
  {
    var instance = new TestJumonyHandler();
    instance.ProcessRequest( context );
    return instance.response;
  }


  private ICachedResponse response;

  protected override void OutputResponse( HttpContextBase context, ICachedResponse responseData )
  {
    response = responseData;

  }

}