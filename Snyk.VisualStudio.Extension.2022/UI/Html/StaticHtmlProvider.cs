﻿namespace Snyk.VisualStudio.Extension.UI.Html
{
    public class StaticHtmlProvider : BaseHtmlProvider
    {
        private static StaticHtmlProvider _instance;

        public static StaticHtmlProvider Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StaticHtmlProvider();
                }
                return _instance;
            }
        }
        public override string GetInitScript()
        {
            return string.Empty;
        }

        public string GetInitHtml()
        {
            return @"
                <!DOCTYPE html>
                <html>
                <head>
                <meta http-equiv='Content-Type' content='text/html; charset=unicode' />
                <meta http-equiv='X-UA-Compatible' content='IE=edge' />
                <meta charset=""utf-8"" />
                <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
                <meta http-equiv=""Content-Security-Policy""
                      content=""style-src 'self' 'nonce-${nonce}' 'nonce-ideNonce' https://fonts.googleapis.com;
                           script-src 'nonce-${nonce}' https://fonts.googleapis.com;
                           font-src 'self' https://fonts.gstatic.com;"" />
                  <style>
                :root {
                  font-size:15px;
                }
                p { font-size:1.3rem; margin: .8rem 0;  }
                body { background-color: var(--ide-background-color); color: var(--text-color); font-family: sans-serif; padding: 12px; opacity: 0.4;}
                .snx-loader { display:inline-block; width: 12px; height: 12px; border: 2px solid rgba(125,125,125,.65); border-bottom-color: transparent; border-radius: 50%; margin-right:.8rem; animation: spin 1s linear infinite;
                }
                .size-s { width: 12px; height: 12px; border-width:2px }
                .size-m { width: 16px; height: 16px; border-width:3px; }
                .size-l { width: 24px; height: 24px; border-width:4px; }
                .hidden {display: none}
                @keyframes spin {
                  from { transform: rotate(0deg); }
                  to { transform: rotate(360deg); }
                }

                .snx-h1 { font-size: 2rem; font-weight: 600; margin: .8rem 0; }

                .snx-status { display:flex; align-items:center; padding: .4rem 1.2rem; background-color: rgba(255,255,255,.1); border-radius: 1rem; }

                .snx-header { display: flow-root; gap:1.6rem; }
                .snx-message { display: flex; align-items: center }

                  </style>
                </head>
                <body>
  
                  <div class=""snx-header"">
                    <h1 class=""snx-title snx-h1"">Snyk Security is loading...</h1>
                  </div>
                  <div class=""snx-summary"">
                    <div class=""snx-status"">
                      <span class=""snx-loader size-s""></span>
                      <p class=""snx-message"">Waiting for the Snyk CLI to be downloaded and the Language Server to be initialized. </p>
                    </div>
                  </div>
                </body>
                </html>
            ";
        }

    }
}