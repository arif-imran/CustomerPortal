using System;
namespace CustomerPortalApp.Styles
{
    public static class Styles
    {
        /// <summary>
        /// Gets the mayfair belgravia.
        /// </summary>
        /// <value>The mayfair belgravia.</value>
        public static string MayfairBelgravia { get; }

        /// <summary>
        /// Gets the unsemantic base.
        /// </summary>
        /// <value>The unsemantic base.</value>
        public static string UnsemanticBase { get; }

        /// <summary>
        /// Initializes the <see cref="T:CustomerPortalApp.Styles.Styles"/> class.
        /// </summary>
        static Styles()
        {
            MayfairBelgravia = @"html, body, body div, span, object, iframe, h1, h2, h3, h4, h5, h6, p, blockquote, pre, abbr, address, cite, code, del,
             dfn, em, img, ins, kbd, q, samp, small, strong, sub, sup, var, b, i, dl, dt, dd, ol, ul, li, fieldset, form, label,
             legend, table, caption, tbody, tfoot, thead, tr, th, td, article, aside, figure, footer, header, menu, nav, section, time, mark,
             audio, video, details, summary {
                margin: 0;
                padding: 0;
                border: 0;
                font-size: 100%;
                vertical-align: baseline;
                background: transparent;
            }                                   

            /* consider resetting the default cursor: https://gist.github.com/murtaugh/5247154 */

            article, aside, figure, footer, header, nav, section, details, summary {display: block;}

            /* Responsive images and other embedded objects
               Note: keeping IMG here will cause problems if you're using foreground images as sprites.
               If this default setting for images is causing issues, you might want to replace it with a .responsive class instead. */
            img,
            object,
            embed {max-width: 100%;}
            .map img{max-width: inherit;}
            /* force a vertical scrollbar to prevent a jumpy page */
            html {overflow-y: scroll;}

            /* we use a lot of ULs that aren't bulleted. 
                don't forget to restore the bullets within content. */
            ul {list-style: none;}

            blockquote, q {quotes: none;}

            blockquote:before, 
            blockquote:after, 
            q:before, 
            q:after {content: ''; content: none;}

            a {margin: 0; padding: 0; font-size: 100%; vertical-align: baseline; background: transparent;}

            del {text-decoration: line-through;}

            abbr[title], dfn[title] {border-bottom: 1px dotted #000; cursor: help;}

            /* tables still need cellspacing=""0"" in the markup */
            table {border-collapse: collapse; border-spacing: 0;}
            th {font-weight: bold; vertical-align: bottom;}
            td {font-weight: normal; vertical-align: top;}

            hr {display: block; height: 1px; border: 0; border-top: 1px solid #D7D7D7; margin: 1em 0; padding: 0;}

            input, select {vertical-align: middle;}

            pre {
                white-space: pre; /* CSS2 */
                white-space: pre-wrap; /* CSS 2.1 */
                white-space: pre-line; /* CSS 3 (and 2.1 as well, actually) */
                word-wrap: break-word; /* IE */
            }

            input[type=""radio""] {vertical-align: text-bottom;}
            input[type=""checkbox""] {vertical-align: bottom;}
            .ie7 input[type=""checkbox""] {vertical-align: baseline;}
            .ie6 input {vertical-align: text-bottom;}

            select, input, textarea {font: 99% sans-serif;}

            table {font-size: inherit; font: 100%;}

            small {font-size: 85%;}

            strong {font-weight: bold;}

            td, td img {vertical-align: top;} 

            /* Make sure sup and sub don't screw with your line-heights
                gist.github.com/413930 */
            sub, sup {font-size: 75%; line-height: 0; position: relative;}
            sup {top: -0.5em;}
            sub {bottom: -0.25em;}

            /* standardize any monospaced elements */
            pre, code, kbd, samp {font-family: monospace, sans-serif;}

            /* hand cursor on clickable elements */
            .clickable,
            label, 
            input[type=button], 
            input[type=submit], 
            input[type=file], 
            button {cursor: pointer;}

            /* Webkit browsers add a 2px margin outside the chrome of form elements */
            button, input, select, textarea {margin: 0;}

            /* make buttons play nice in IE */
            button {width: auto; overflow: visible;}
             
            /* scale images in IE7 more attractively */
            .ie7 img {-ms-interpolation-mode: bicubic;}

            /* prevent BG image flicker upon hover */
            .ie6 html {filter: expression(document.execCommand(""BackgroundImageCache"", false, true));}

            /* let's clear some floats */
            .clear:before, .clear:after,
            .clearfix:before, .clearfix:after { content: ""\0020""; display: block; height: 0; overflow: hidden; }  
            .clear:after,
            .clearfix:after { clear: both; } 
            .clear,
            .clearfix { zoom: 1; }  


            /*#Global#*/
            * {
                -moz-box-sizing: border-box;
                -webkit-box-sizing: border-box;
                box-sizing: border-box;
            }

            .chromeframe {
                position: absolute;
                top: 0; 
            }

            body {
                font-family:'amplitude-bookregular'; /*widths in formulae: Required element pixel value ÷ parent font size in pixels = em value*/
                background-color: #ebebeb;
            }

            .bodyamp {
              font-family:'amplitude-bookregular'; font-size: 1.125em; line-height: 1.500em;
            }

            .hpboxtext {
              font-family:'new_century_schoolbookroman'; font-size: 0.813em; line-height: 1.063em;
            }

            .shopping-areas {
              font-family:'amplitude-bookregular'; font-size: 1.125em; line-height: 1.500em;
            }

            .smallboxtext {
              font-family:'new_century_schoolbookroman'; font-size: 0.875em; line-height: 1.000em;  margin-top: -0.500em;
            }

            .headercopy {
              font-family:'new_century_schoolbookroman'; font-size: 1.125em; line-height: 1.500em;
            }

            .landingsmall {
              font-family:'new_century_schoolbookroman'; font-size: 0.813em; line-height: 1.250em;
            }
            .linkboxpad {
              padding: 1.000em 1.000em 0.125em 1.063em
            }

            .projectslargetitle {
              font-family:'new_century_schoolbookroman'; font-size: 2.250em;
            }

            .projectstitle {
              font-family:'amplitude-bookregular'; font-size: 1.125em; color: #707070;
            }

            .projectsheading {
              font-family:'new_century_schoolbookroman'; font-size: 1.500em;
            }

            .projectsimg {
              padding: 0em 1em 3em 0.750em;
            }

            .hpboxcopy {
              font-family:'new_century_schoolbookroman'; font-size: 0.875em; line-height: 0.813em; 
            }

            .hpcarouselpad {
              padding-bottom: 0.625em;
            }

            .morebutton {
                padding-top: 1em;
                text-align: center;
            }
            .morebutton a {
                background: #ffffff;
                padding: 0.5em 0.7em;
                text-transform: uppercase;
            }

            .accordionclosed {
              background-color: #d7d7d7; 
              background: #d7d7d7 url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/down.png') 96% 50% no-repeat;
              font-family:'amplitude-bookregular'; 
              font-size: 1.125em; 
              padding: 0.750em 3em 0.750em 1.250em; 
              border-bottom-color: #ebebeb; 
              border-bottom-style: solid; 
              border-bottom-width: 1px;
              cursor: pointer;
            }

            .accordionopen {
              background-color: #ffffff;
              background: #ffffff url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/up.png') 96% 50% no-repeat;
              font-family:'amplitude-bookregular'; 
              font-size: 1.125em; 
              color: #1a7462; 
              padding: 0.750em 3em 0.750em 1.250em; 
              border-bottom-color: #ebebeb; 
              border-bottom-style: solid; 
              border-bottom-width: 1px;
            }

            .accordiontextopen {
              background-color: #ffffff; font-family:'amplitude-bookregular'; font-size: 1.125em; padding: 0.750em 1.250em 0.750em 1.250em;
            }

            .accordionv {
              background: url(http://www.grosvenorlondon.com/CMSPages/v.png)
            }

            .hpbiglink {
              font-family:'new_century_schoolbookroman';
              font-size: 1.500em;
              line-height: 1.500em;
              border-bottom: 1px solid #d7d7d7;
            }

            .visually-hidden {
                position: absolute; 
                overflow: hidden; 
                clip: rect(0 0 0 0); 
                height: 1px; width: 1px; 
                margin: -1px; padding: 0; border: 0; 
            }

            /* Uploader */
            .UploaderCurrentFile
            {
                width: auto;
                color: #0000ff;
                text-decoration: underline;
                float: left;
                margin-left: 5px;
                font-family: Verdana;
                font-size: 12px;
            }

            .RTL .UploaderCurrentFile
            {
                float: right;
                margin-left: auto;
                margin-right: 5px;
            }

            .UploaderDelete
            {
                vertical-align: middle;
                float: left;
            }

            .RTL .UploaderDelete
            {
                float: right;
            }

            .UploaderAction
            {
                margin-right: 5px;
                vertical-align: middle;
                float: left;
            }

            .RTL .UploaderAction
            {
                margin-left: 5px;
                float: right;
            }

            .UploaderWebDAVEdit
            {
                margin-right: 5px;
                vertical-align: middle;
                float: left;
            }

            .RTL .UploaderWebDAVEdit
            {
                margin-left: 5px;
                float: right;
            }

            .UploaderLabel
            {
                margin-right: 5px;
            }

            .RTL .UploaderLabel
            {
                margin-right: auto;
                margin-left: 5px;
            }

            .Uploader
            {
                background-color: #ffffff;
                border: solid 1px #cccccc;
                padding: 3px;
                min-width: 288px;
                display: table;
            }

            .Uploader .Uploader
            {
                width: 283px;
            }

            .IE .Uploader
            {
                width: auto;
                min-width: 290px;
            }

            .Uploader
            {
                border: solid 1px #cccccc;
                background-color: #ffffff;
            }

            .HiddenButton
            {
                display: none;
            }

            /* Photo competition */
            .photo-comp.webform .TextBoxField, 
            .photo-comp.webform .DropDownField,
            .photo-comp.webform .TextAreaField {
                margin: 5px 0 20px;
            }

            .webform-checkbox div {
              float: left;
              margin-right: 10px;
            }

            .webform-checkbox .label {
              display: inline-block;
              overflow: hidden;
            }


            /* email forms */
            .webform:not(.photo-comp) label { 
                position: absolute; 
                overflow: hidden; 
                clip: rect(0 0 0 0); 
                height: 1px; width: 1px; 
                margin: -1px; padding: 0; border: 0; 
            }
            .webform .ErrorLabel{
                padding-top: 20px;
                text-align: center;
                display: block;
                color: red;
            }
            .webform .EditingFormErrorLabel {
                padding-left: 1em;
                color: red;
            }
            .InfoLabel {
              display: block;
              padding-bottom: 10px;
              padding-top: 20px;
              background: none;
              text-align: center;
            }
            .webform .TextBoxField, 
            .webform .DropDownField,
            .webform .TextAreaField {
                width: 100%;
                margin: 10px 0;
                border: 1px solid #d7d7d7;
                background-color: #f6f6f6;
            }
            .webform .TextBoxField {
                height: 2.5em;
                padding: 1em 1em;
            }
            .webform .DropDownField {
                height: 2.5em;
                padding: 0 0 0 0.5em;
                border: 1px solid #d7d7d7;
                -webkit-appearance: none;
                -moz-appearance: none;
                background: url('http://www.grosvenorlondon.com/images/generic/webform-dropdown.png') no-repeat #f6f6f6;
                background-position: 95% 0.9em;
                text-indent: 0.01px;
                text-overflow: """";
            }
            .webform .TextAreaField {
                padding: 1em;
                max-width: 100%;
                height: 8em;
            }
            .Gecko .webform .EditingFormErrorLabel {
                padding-left: 0.6em;
            }
            .Gecko .webform .TextBoxField {
                height: auto;
                padding: 0.6em;
            }
            .Gecko .webform .DropDownField {
                height: 2.6em;
                padding: 0.6em 0px 0.6em 0.5em;
            }
            .IE8 .webform .TextBoxField {
                padding-top: 0.6em;
            }
            .IE8 .webform .DropDownField {
                background: #f6f6f6;
                padding-bottom: 0.6em;
            }
            .IE9 .webform .TextBoxField {
                padding-top: 0.6em;
            }
            .IE9 .webform .DropDownField {
                background: #f6f6f6;
                padding-bottom: 0.6em;
            }
            .DropDownField::-ms-expand {
            display: none;
            }

            .webform input::input-placeholder,
            .webform input::-webkit-input-placeholder,
            .webform input:-moz-placeholder,
            .webform input::-moz-placeholder,
            .webform input:-ms-input-placeholder {  
               color: #ebebeb;  
            }

            .webform .center {
                text-align: center;
            }
            .webform .FormButton {
                color: #fff;
                border: none;
                margin: 0;
                padding: 0.4em 1.4em;
                text-transform: uppercase;
                background: #707070;
                font-family: 'amplitude-bookregular';
                font-weight: normal;
                font-size: 95%; 
            }
            .webform .forminfo {
                text-align: center;
                text-transform: uppercase;
                color: #1a7462;
                padding-top: 20px;
            }

            body, select, input, textarea {
                color: #1d1d1b;
            }

            .WebPart .grid-5, .WebPart .mobile-grid-5, .WebPart .grid-10, .WebPart .mobile-grid-10, .WebPart .grid-15, .WebPart .mobile-grid-15, .WebPart .grid-20, .WebPart .mobile-grid-20, .WebPart .grid-25, .WebPart .mobile-grid-25, .WebPart .grid-30, .WebPart .mobile-grid-30, .WebPart .grid-35, .WebPart .mobile-grid-35, .WebPart .grid-40, .WebPart .mobile-grid-40, .WebPart .grid-45, .WebPart .mobile-grid-45, .WebPart .grid-50, .WebPart .mobile-grid-50, .WebPart .grid-55, .WebPart .mobile-grid-55, .WebPart .grid-60, .WebPart .mobile-grid-60, .WebPart .grid-65, .WebPart .mobile-grid-65, .WebPart .grid-70, .WebPart .mobile-grid-70, .WebPart .grid-75, .WebPart .mobile-grid-75, .WebPart .grid-80, .WebPart .mobile-grid-80, .WebPart .grid-85, .WebPart .mobile-grid-85, .WebPart .grid-90, .WebPart .mobile-grid-90, .WebPart .grid-95, .WebPart .mobile-grid-95, .WebPart .grid-100, .WebPart .mobile-grid-100, .WebPart .grid-33, .WebPart .mobile-grid-33, .WebPart .grid-66, .WebPart .mobile-grid-66 {
                float:none; /* fix for design mode view in CMS */
            }
            /*#Global/Links#*/
            a {
                color: #1a7462;
                    text-decoration: none;
            }

                a:hover {
                text-decoration: underline;
                }

            ::-moz-selection {
                background: #fcd700;
                color: #fff;
                text-shadow: none;
            }

            ::selection {
                background: #fcd700;
                color: #fff;
                text-shadow: none;
            }

            a:link {
                -webkit-tap-highlight-color: #fcd700;
            }

            a.act:link {color: #000000; text-decoration: none;}
            a.act:visited {color: #000000; text-decoration: none;}
            a.act:hover {color: #1a7462; text-decoration: underline;}

            ins {
                background-color: #fcd700;
                color: #000;
                text-decoration: none;
            }

            mark {
                background-color: #fcd700;
                color: #000;
                font-style: italic;
                font-weight: bold;
            }

            input:-moz-placeholder {
                color: #a9a9a9;
            }

            textarea:-moz-placeholder {
                color: #a9a9a9;
            }

            h1, h2, h3, h4, h5, h6 {
                margin-bottom: 0;
                font-weight:normal;
            }



            p {
                margin: 0 0 0.5em;
            }

            h1 {
                font-size: 2em;
            }

            h2 {
                font-size: 1.5em; font-family:'new_century_schoolbookroman'; line-height: 1.312em;
            }

            h3 {
                font-size: 1.125em; font-family:'new_century_schoolbookroman';
            }

            h4 {
                font-size: 0.875em;
            }

            h5 {
                font-size: 0.75em;
            }

            h6 {
                font-size: 0.625em;
            }

            .italic,
            em {
                font-style: italic;
            }

            strong {
                font-weight: bold;
            }

            blockquote {
                padding:0;
                margin:0;
              background:none;
              font-family:'new_century_schoolbookroman'; 
            }
                blockquote span {
                    font-size:1.875em!important;
                    display:inline;
                }
            blockquote:before
             {
              content: ""\201C"";
              font-size: 3em;
              line-height:1em;
            }

            blockquote:after
             {
              content: ""\201D"";
              font-size: 3em;
              display:block;
              line-height:1em;
            }

            .pullout {
              font-family: 'new_century_schoolbookroman'; font-size: 1.875em;
            }

            .fontamplitude {
                font-family: 'amplitude-bookregular';
            }
            .fontnewcentury {
                font-family: 'new_century_schoolbookroman';
            }
            .content ol li {
                list-style-type: decimal;
                padding-bottom: 0.85em;
            }

            .content ul li {
                list-style-type: disc;
                padding-bottom: 0.85em;
            }

            ol.normal li {
                    list-style-position: outside;
                    margin-left: 2em;
                    padding-bottom: 0.613em;
                }

            ul.standard li {
                    list-style-type: disc;
                    list-style-position: outside;
                    margin-left: 1em;
                    padding-bottom: 0.613em;
                }

            ul.downloads li {
                    background-image: url(http://www.grosvenorlondon.com/images/generic/download_icon.gif);
                    background-repeat: no-repeat;
                    padding-left: 2.000em;
                    padding-bottom: 0.613em;
                }

            ul.downloadsrh li {
                    background-image: url(http://www.grosvenorlondon.com/images/generic/download_icon.gif);
                    background-repeat: no-repeat;
                    padding-left: 2.500em;
                    padding-bottom: 0.613em;
                    font-family: 'amplitude-bookregular';
                    font-size: 0.875em;
                }

            .button {
                font-size: 0.875em;
                border: none;
                display:inline-block;
                font-family:'amplitude-bookregular';
                color:#fff;
                background-color:#1a7462;
                text-transform:uppercase;
                line-height:1.8571em;
                padding:0 0.857em;

            }
                .button:hover,
                .button.over {
                    color:#1a7462;
                    background-color:#ebebeb;
                    text-decoration:none;
                }

            .button_clear {
                font-size: 0.875em;
                border: none;
                display:inline-block;
                font-family:'amplitude-bookregular';
                color:#1d1d1b;
                line-height:1.8571em;
                padding:0 0.857em;

            }
                .button_clear:hover,
                .button_clear.over {
                    text-decoration:underline;
                }


            .masonry-container:before,
              .masonry-container:after {
                content: ""."";
                display: block;
                overflow: hidden;
                visibility: hidden;
                font-size: 0;
                line-height: 0;
                width: 0;
                height: 0;
              }

              .masonry-container:after {
                clear: both;
              }

              .masonry-container{
                /* <IE7> */
                *zoom: 1;
                /* </IE7> */
              }

              .masonry-container {
                margin-left: auto;
                margin-right: auto;
                max-width: 60em;
              }

            .left {
                float: left;
            }

            .right {
                float: right;
            }

            /*#Zones/Common#*/
            #footer > .inner,
            #main,
            #header > .inner,
            nav .navigation__inner {
                max-width: 60em; /*960*/
                min-width: 18.75em /*300*/;
                margin: 0 auto;
            }

            /*#Zones/Header#*/
            #header,
            .navigation {
                background: #ebebeb;
                position: relative;
                z-index: 10;
            }

            #header > .inner {
                padding: 2.5em 0.625em 1.8125em 0.625em;
                border-bottom: 1px solid #D7D7D7;
                text-align: center;
            }
                #header h1 {
                    float: left;
                }
                #header h2 {
                    float: right;
                }

            .header__controls__btn {
                border: 1px solid #D7D7D7;
            }
            /*#Items/TopMenu#*/
            nav {
                position: relative;
            }
            nav #subnav {
                border-top: 1px solid #D7D7D7;
            } 
            #aboutnav {
                font-family: 'amplitude-bookregular';
                font-weight: 400;
            }
            #subnav {
                font-family: 'amplitude-bookregular';
                font-weight: 400;
                margin: 0 0.625em;
            }
            #nav {
                font-family: 'amplitude-bookregular';
                font-weight: 400;
                float:left;
                width:100%;
                padding-right:11.875em;
            }

                #nav > a {
                    display: none;
                }
                #aboutnav li,
                #subnav li,
                #nav li {
                    position: relative;
                    white-space: nowrap;
              
                }
                 #aboutnav li a,
                 #subnav li a,
                    #nav li a {
                     color:#1d1d1b;
                        display: block;
                        text-decoration: none;
                    }
                      
                #nav span:after {
                    width: 0;
                    height: 0;
                    border: 0.313em solid transparent; /* 5 */
                    border-bottom: none;
                    border-top-color: #efa585;
                    content: '';
                    vertical-align: middle;
                    display: inline-block;
                    position: relative;
                    right: -0.313em; /* 5 */
                }

                /* first level */
                #aboutnav > ul,
                 #subnav > ul,
                #nav > ul {
                    height: 2.75em; /* 44 */
                }
                    #aboutnav > ul > li,
                    #subnav > ul > li,
                    #nav > ul > li {
                        height: 100%;
                        float: left;
                    }
                        #aboutnav > ul > li > a,
                        #subnav > ul > li > a,
                        #nav > ul > li > a {
                            height: 100%;
                            font-size: 0.875em; /* 14 */
                            line-height: 3.14286em; /* 44 (14) */
                            text-align: center;
                            margin: 0 1.071428571428571em;
                            text-transform: uppercase;
                        }

                        #nav > ul > li > a {
                            font-size: 15px;
                            line-height: 2.75em;
                        }

                        
                        #nav > ul > li:hover a {
                            background-color: #fff;
                        }
                        #aboutnav > ul:not( :hover ) > li.HighLighted > a,
                        #subnav > ul:not( :hover ) > li.HighLighted > a,
                    #nav > ul:not( :hover ) > li.HighLighted > a{
                        border-bottom:2px solid rgba(68, 140, 125, 0.20);
                    }
                /* second level */

                #nav li ul {
                    position: absolute;
                    top: 100%;
                    min-width: 100%;
                    width: auto;
                    left: -999em; /* Hides the drop down */
                    z-index: 10;
                    display: none;
                }

                    #nav li ul li {
                        width: 100%;
                        background-color: #fff;
                    }

                #nav li:hover ul {
                    display: block;
                    left: 0;
                }

                #nav li:first-child:hover ul {
                    left: 10px
                }

                #nav li ul a {
                    font-size: 0.875em; /* 14 */
                    padding: 0.7142857142857143em 1.071428571428571em; /* 10 (14) */
                }


                #nav ul li > a:hover,
                #subnav ul li > a:hover,
                #aboutnav ul li > a:hover,
                #nav ul:not( :hover ) li.HighLighted > a,
                #subnav ul:not( :hover ) li.HighLighted > a,
                #aboutnav ul:not( :hover ) li.HighLighted > a {
                    color: #1a7462;
                }


              #subnav ul,
              #aboutnav ul {
                    height: 2.75em; /* 44 */
                }
                    #subnav ul > li,
                    #aboutnav ul > li {
                        height: 100%;
                        float: left;
                    }
                        #subnav ul > li > a,
                        #aboutnav ul > li > a {
                            height: 100%;
                            font-size: 0.875em; /* 14 */
                            line-height: 3.14286em; /* 44 (14) */
                            text-align: center;
                            margin: 0 1.071428571428571em;
                        }

                        #subnav ul:not( :hover ) > li.HighLighted > a,
                        #aboutnav ul:not( :hover ) > li.HighLighted > a {
                        border-bottom:2px solid rgba(68, 140, 125, 0.20);
                    }

            #search {
                   font-family: 'amplitude-bookregular';
                font-weight: 400;
                    position: absolute;
                    right: 0;
                    top:0;
                    margin-right:10px;
            }

                #search .searchBox-wrap {
                    background: #fff;
                    border-bottom: 10px solid #1A7462;
                    line-height: 1.5em;
                    padding: 10px 10px 35px 10px;
                    position:relative;
                }

                    #search .searchBox input.textbox {
                        background: #F6F6F6;
                        border: 1px solid #D7D7D7;
                        line-height: 0.875em;
                        font-size: 15px;
                        padding:10px;
                        color:#1d1d1b;
                        font-family: 'new_century_schoolbookroman';
                        width:100%;
                        -webkit-transition: all .5s ease;
                        -moz-transition: all .5s ease;
                        transition: all .5s ease;
                    }

            /*#search .searchBox input.textbox:focus {
               width: 200px;
            }*/
            #search .searchBox input.submit {
                        position:absolute;
                        top:20px;
                        right:20px;
                        vertical-align:middle;
                    }
                #search > a {
                    display: none;
                }

            #search > a {
                /*display: block;*/
                width: 20px;
                height: 39px;
                text-align: left;
                text-indent: -9999px;
            }

            .search__search {
                margin-right: 12px;
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/search-icon2.png') no-repeat center;
            }

            .search__search.is-active {
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/cross.png') no-repeat center;
            }

            .search__twitter {
                margin-left: 12px;
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/twitter.png') no-repeat center;
            }

            .search__divider {
                float: left;
                display: block;
                width: 1px;
                background-color: #D7D7D7;
                height: 20px;
                margin-top: 10px;
            }

            .overlay {
                position: fixed;
                background: rgba( 255, 255, 255, .75 );
                top: 0;
                left: 0;
                width: 100%;
                height: 100%;
                z-index: 5;
            }

            #search .searchBox label {
                position: absolute; 
                overflow: hidden; 
                clip: rect(0 0 0 0); 
                height: 1px; width: 1px; 
                margin: -1px; padding: 0; border: 0; 
            }

            .carouselWrapper {
                width:100%;
                overflow: hidden;
                position: relative;
            }

            .carouselWrapper > .prev, .carouselWrapper > .next,
            .carouselWrapper > .mini-carousel__prev, .carouselWrapper > .mini-carousel__next{
                position: absolute;
                top: 50%;
                display: block;
                 height:33px;
                 width:33px;   
                  margin-top: -12px;
            }

                .carouselWrapper > .prev:hover, .carouselWrapper > .next:hover,
            .carouselWrapper > .mini-carousel__prev:hover, .carouselWrapper > .mini-carousel__next:hover{
                    background-color: #eeeef5;
                    background-color: rgba(255, 255, 255, 0.2);
                }

            .carouselWrapper > .prev,
            .carouselWrapper > .mini-carousel__prev{
               left: 10px;
            }

            .carouselWrapper > .next,
            .carouselWrapper > .mini-carousel__next{
               right: 10px;
            }
            .carouselWrapper .item{
                float:left;
            }
            .carouselWrapper .item img{
                display:block;
            }
                .carouselWrapper > .prev span, .carouselWrapper > .next span,
            .carouselWrapper > .mini-carousel__prev span, .carouselWrapper > .mini-carousel__next span{
                    position: absolute;
                    top: 0;
                    display: block;
                    height: 100%;
                    width: 33px;
                     background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/slider-arrows.png') no-repeat scroll 0 50% transparent;
                }
                .carouselWrapper > .next span,
            .carouselWrapper > .mini-carousel__next span{
                    background-position: -33px 50% ;
                }

            .thumbsWrapper {
                max-width: 58.75em; /*940*/
                min-width: 18.75em; /*300*/
                margin: 0 auto;
            }
            #box-carousel .propertyitem {
                float: left;
            }
            #box-carousel .carouselWrapper  {
                max-width: 460px; 
                /*max-height:495px;*/
            }
            #box-carousel .carouselWrapper > .prev, 
            #box-carousel .carouselWrapper > .next {
                 top:150px;
                  margin-top: 0;
            }
            #home-carousel .carouselWrapper {
                max-width: 940px; 
                min-width: 300px;
                max-height:475px;
                margin:0 auto;
            }
              #home-carousel .item h4 {
                    font-family: 'amplitude-bookregular';
                    text-transform: uppercase;
                    font-weight: normal;
                }
                #home-carousel .item h2 {
                    font-size: 3em;
                    font-weight: normal;
                    margin-bottom: 0.3em;
                }
                #home-carousel .item p {
                    font-size: 1.125em; 
                }
            #home-carousel .thumb {
                font-size: 0.875em;
                width: 17.0714em;
                height: 5.5em;
                text-align: center;
                display: table-cell;
                vertical-align: middle;
            }

            #home-carousel .sep {
                font-size: 0.875em;
                display: table-cell;
                padding-top: 1em;
                width: 1px;
            }

                #home-carousel .sep span {
                    background: #cccccc;
                    display: block;
                    height: 3.3571em;
                }

            #home-carousel .thumb.selected {
                background: #fff;
            }

            #home-carousel .thumb a {
                color: #1a7462!important;
                text-decoration: none;
            }

            #home-carousel .thumb .name {
                text-transform: uppercase;
                color: #1d1d1b;
                display: block;
                font-family: 'amplitude-bookregular';
            }
            #home-carousel .thumbsWrapper {
                border-bottom: 1px solid #D7D7D7;
            }
            #property-carousel .carouselWrapper {
                max-width: 940px; 
                min-width: 300px;
                max-height:475px;
              margin:0 auto;
            }
            #property-carousel {
                margin-bottom: 2.5em;
            }
            #property-carousel .thumbsBg {
                background-color:#fff;
            }
            #property-carousel .thumb {
                float:left;
                padding:1.25em 1.25em 1.25em 0;
            }
            #property-carousel .thumb:last-child {
                padding-right:0;
            }
            #property-map {
                display:none;
                margin: 0 auto 2.5em auto; 
                max-width: 940px;
                min-width: 300px;
            }
            #property-tabs {
                margin: 0 auto;
                width: 100%;
              max-width: 940px;
                text-align:right;
                margin-top:-1em;
            }
                #property-tabs a {
                    display:inline-block;
                    text-transform:uppercase;
                    padding:1em;
                    border-left:1px solid #ccc;
                    background-color:#f5f5f5;
                    font-size:0.875em;
                }
                   #property-tabs a.selected {
                    background-color:#fff;
                }
                #property-tabs a:first-child {
                    border-left:none;
                }
            /*#Zones/Footer*/
            #footer {
                background-color: #fff;
                margin-top: 2.25em;
            }

            #bottommenu {
                font-family: 'amplitude-bookregular';
                padding: 3.125em 0.625em 0;
            }

                #bottommenu li {
                    float: left;
                    display: block;
                    position: relative;
                    width: 9.75em;
                    border: none;
                }

                    #bottommenu li a {
                        display: block;
                        padding-bottom: 1.0714em;
                        color:#1d1d1b;
                        text-decoration: none;
                        text-transform: uppercase;
                        font-size: 0.875em; /* 14 */
                    }

                    #bottommenu li ul li a {
                        color: #707070;
                        text-transform: none;
                    }

                    #bottommenu li a:hover{
              text-decoration:underline;
              }
            #footermenu {
                font-family: 'amplitude-bookregular';
                margin: 0 0.625em 0;
                padding-top: 1.25em;
                border-top: 1px solid #D7D7D7;
            }

                #footermenu li {
                    float: left;
                    display: block;
                    position: relative;
                    border: none;
                }

                    #footermenu li a {
                        display: block;
                        padding-bottom: 1.0714em;
                        text-decoration: none;
                        color: #707070;
                        font-size: 0.875em; /* 14 */
                        white-space: nowrap;
                        margin: 0 0.7143em;
                    }

            #footermenu li a:hover{
              text-decoration:underline;
              }
                #footermenu > ul > li + li:before {
                    content: "" . "";
                    float: left;
                    color: #707070;
                    font-size: 0.875em; /* 14 */
              
                }

                #footermenu > ul > li:first-child > a {
                    margin-left: 0;
                }

            #footerlogo {
                display: none;
            }



            .box {
                    padding-bottom:1.25em;
                }

            .box p{
                    font-size:1em!important;
                    font-family:'new_century_schoolbookroman'; 
                }
            .box h2 {
                font-weight: normal;
                padding-bottom: 0.5em;
                font-family:'new_century_schoolbookroman'; 
            }

            .box h4 {
                font-weight: normal;
                text-transform: uppercase;
                padding-bottom: 1em;
            }

            .bgwhite {
                background: #fff;
            }

            .bggreen {
                background: #1a7462;
                color: #fff;
            }
                .bggreen a {
                    color: #fff;
                }

            .m10 {
                margin: 0.625em;
            }

            .p10 {
                padding: 0.625em;
            }

            .p15 {
                padding: 0.937em;
            }

            .p20 {
                padding: 1.25em;
            }
            .noleftpad{
                padding-left:0!important;
              }
            .norightpad{
                padding-right:0!important;
              }
            .notoppad{
                padding-top:0!important;
              }
            .nobottompad{
                padding-bottom:0!important;
              }
            #main > .inner {
                border-top: 1px solid #D7D7D7;
                padding: 0.625em 0 0.625em;
                margin: 0 0.625em;
            }
            #main.home > .inner {
                border-top: none;
                margin: 0;
            }
            #main h1 {
                font-size: 3em;
                margin-bottom:0.4em;
            }
            #main h4 {
                font-family: 'amplitude-bookregular';
                font-weight: normal;
                text-transform: uppercase;
            }
            #main p {
                font-size: 1.125em;
            }

            #directory {
                background-color:white;
                max-width:58.75em;
                color:#707070;
                margin-bottom:1em;
            }
            #directory .top {
                border-bottom:1px solid #d7d7d7;
            }

                #directory .top .grid-50 {
                    height:3.5625em;
                    padding:0;
                }
                 #directory .top .grid-50:first-child{
              
                    padding-left:1.25em;
                }
            #directory .top .grid-50:last-child{
              
                    padding-right:1.25em;
                }
                 #directory .top h1 {
                    font-size:1.5em;
                    line-height:2.375em;
                    margin:0;
                    padding:0;
                }
                 #directory .top .viewas {
                    margin:0;
                    padding:0;
                    text-transform:uppercase;
                    font-family:'amplitude-bookregular';
                    line-height:4.0714em;
                    font-size:0.875em;
                    text-align:right;
                }
                    #directory .top .viewas a.list, 
                    #directory .top .viewas a.map {
                        background-color:#1a7462;
                        color:#fff;
                        padding:7px 5px 8px 0;
                    }
                    #directory .top .viewas a.list_selected,
                    #directory .top .viewas a.map_selected {
                        background-color:#ebebeb;
                        color:#1a7462;
                        padding:7px 5px 8px 0;
                    }
                     #directory .top .viewas a.map_selected .gr-icon-map{
                        background-position:-109px -138px; /*.gr-icon-map2*/
                    }
                    #directory .top .viewas a.list_selected .gr-icon-list{
                        background-position:-172px -139px; /*.gr-icon-list2*/
                    }
            #directorymain {
                border-left:1px solid #d7d7d7;
            }
            #directorybottom {
                /*border-top:1px solid #d7d7d7;*/
                background-color:#EBEBEB;
            }

                #directoryleft .box {
                    padding-bottom:0;
                }
                #directoryleft .box h2{
                    font-size:1.3125em;
                }
                #directoryleft .box h3{
                    font-size:1.125em;
                }
                #directoryleft .box p {
                    font-size:1.0625em;
                }
            .filter {
                padding:1.25em;
            }
               .filter h2 {
                    font-style:italic;
                }
            .filter h3,
            .filter a.toggle,
            .filter a.slidetoggle{
                    font-size:0.875em;
                font-family:'amplitude-bookregular';
                text-transform:uppercase;
                }
            .filter a.slidetoggle{
              line-height: 2.3em;
              }
            .filter h3 {
                    color:#a8a8a8;
                }
            .filter select {
                 font-size:0.75em;
                 width:100%;
                 margin-bottom:0.83em;
            }

            .contactus .bggreen {
                padding:1.25em;
                 font-family: 'new_century_schoolbookroman';
            }

            .contactus .bggreen ul{
                margin-bottom:1.2em;
            }

            .contactus .bggreen li a {
                   color:#ffffff!important;
                }

            /*#Right-hand boxes*/

            .rhdownloadtitle {
              font-size: 1.000em; font-family: amplitude-bookregular
            }

            .rhdownloadlink {
              font-size: 1.000em; font-family: amplitude-bookregular
            }

            .downloadicon {
              padding-right: 0.938em; float: left;
            }

            .rhboxtext {
              font-size: 0.875em; font-family: amplitude-bookregular;
            }

            #directory .sort {
                border-bottom: 1px solid #d7d7d7;
            }
            #directory .sort .grid-100,
            #directory .sort .grid-50{
                padding:0 20px;
                font-size:0.875em;
                line-height: 50px;
            }
                #directory .sort .grid-50:last-child {
                    text-align:right;
                }
             #directory .sort .grid-50 select {
                font-size: 0.8571em;
                }

            #directory .pager {
                font-size:0.875em;
                line-height: 50px;
                padding-left: 20px;
            }
            #directory .pager div {
               display:block;
                float:left;
            }
            #directory .pager div.links {
                font-family:'amplitude-bookregular';
                text-transform:uppercase;
                margin-left: 17.1429em;
                float:none;
            }
            div.AspNet-TreeView li input[type=""checkbox""] {
                vertical-align: middle;
            }
            div.AspNet-TreeView li label {
                font-size:0.875em;
                font-family:'amplitude-bookregular';
                padding-left:0.5em;
            }
            div.AspNet-TreeView li ul {
              padding: 0.2em 0 0.2em 1.5em;
            }
            div.AspNet-TreeView li {
                padding-bottom:0.2em;
            }

            .amenity {
                border-bottom: 1px solid #d7d7d7;
            }
                .amenity:hover {
                    background-color:#e8f1ef;
                }
                .amenity .map,
            .amenity .image {
                padding:1.25em;
                float:left;
            }
            .amenity .map{
                float:right;
            }
            .amenity .desc {
                margin:0 8.125em;
                padding:1.25em 0;
            }
                .amenity .desc h2 {
                    font-size:1.3125em!important;
                    margin-bottom:0.2em;
                }
                .amenity .desc h3 {
                    font-size:0.875em!important;
                    margin-bottom:0.5em;
                }
                .amenity .desc p {
                    font-size:0.875em!important;
                    margin-bottom:0.2em;
                }
                .amenity .desc .links a,
                 .amenity .desc .links span {
                    font-family:'amplitude-bookregular';
                    font-size:0.875em!important;
                    text-transform:uppercase;
                }

            .amenitymarker {
                width:450px;
            }
            .amenitymarker .image {
                padding:1.25em;
                float:left;
            }
            .amenitymarker .desc {
                margin:0 0 0 123px;
                padding:1.25em 0;
            }
            .amenitymarker .desc h2,
            .amenitymarker .desc h2 a{
                    font-size:21px;
                }
                .amenitymarker .desc h3{
                    font-size:14px;
                }
                .amenitymarker .desc p{
                    font-size:14px!important;
              font-family: 'new_century_schoolbookroman';
                }
                .amenitymarker .desc .links a,
                 .amenitymarker .desc .links span{
                    font-family:'amplitude-bookregular';
                    font-size:14px;
                    text-transform:uppercase;
                }

            #amenity-detail  {
                background-color:#e8f1ef;
                color:#1d1d1b;
            }
            #amenity-detail .back {
                background-color:#fff;
                border-bottom:1px solid #d7d7d7;
                line-height:3.6429em;
                padding:0 0.7143em;
                font-size: 0.875em; /*14*/
            }
            #amenity-detail .back a {
                color: #1D1D1B;
                text-transform:uppercase;
            }
            #amenity-detail .desc {
                padding:2.625em;
            }
            #amenity-detail .desc h2 {
                    font-size:1.875em;
                    margin-bottom:0.5em;
                }

            .property {
                border-bottom: 1px solid #d7d7d7;
            }

            .property .image {
                padding:1.25em;
                float:left;
            }
            .property .desc {
                margin-left: 18.25em;
                padding:1.25em 1.25em 1.25em 0;
            }
            .property__heading {
                font-size: 18px;
                font-weight: normal;
            }

            .property__letting,
            .property__availability,
            .property__price,
            .property__area,
            .property__description {
                font-family:'amplitude-bookregular';
            }

            .property__letting,
            .property__availability,
            .property__price,
            .property__area {
                font-size: 14px!important;
                color: #3A3A3A!important;
            }

            .property__letting {
                text-transform: uppercase!important;
                margin-bottom: 5px!important;
            }

            .property__availability {
                text-transform: capitalize!important;
                margin-bottom: 5px!important;
            }

            .property__price {
                text-transform: lowercase;!important
                margin-bottom: 10px!important;
            }

            .property__description {
                font-size: 14px!important;
                margin: 0!important;
            }

            .property-detail__letting {
                text-transform: uppercase;
            }

            .property__area {
                text-transform: uppercase!important;
                margin-bottom: 10px!important;
            }

            .property__letting ,
            .property__links a,
            .property__links span {
                font-family:'amplitude-bookregular';
                font-size:0.875em;
                text-transform:uppercase;
            }

            .property__links {
                margin-top: 10px;
            }

            .property__links a {
                background: #1a7462;
                color: #fff!important;
                padding: 5px 10px;
                display: inline-block;
            }

            .property__links a:hover {
                color: #1a7462!important;
                background: #ebebeb;
                text-decoration: none!important;
            }

            #directory .sort {
                overflow: hidden;
            }

            .property-detail__right {
                font-family:'new_century_schoolbookroman';
                margin-top: 5px;
            }

            .property-detail__right .gr-icon {
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/phone-icon.png') no-repeat;
                width: 18px;
                height: 14px;
            }

            @media only screen and (min-width : 37.5em) {
                .property .image {
                    width: 300px;
                }

                .property .image a {
                    display: block;
                }

                .property .image img {
                    width: 100%;
                }

                .property .desc {
                    margin-left: 300px;
                }

                .property__letting,
                .property__availability,
                .property__price,
                .property__area,
                .property__description {
                    font-size: 12px!important;
                }

                .property__header {
                    overflow: hidden;
                    width: 100%;
                    margin-bottom: 5px;
                }

                .property__inner {
                    float: left;
                }

                .property__price {
                    float: right;
                    margin-top: 0;
                }

                .property__heading {
                    font-size: 21px;
                }
            }

            @media only screen and (min-width : 54.375em) {
                .property .image {
                    width: 330px;
                }

                .property .desc {
                    margin-left: 330px;
                }

                .property__letting,
                .property__availability,
                .property__price,
                .property__area,
                .property__description {
                    font-size: 14px!important;
                }

                .property-detail__header {
                    overflow: hidden;
                }

                .property-detail__left {
                    float: left;
                    width: 100%;
                    width: calc( 100% - 210px );
                }

                .property-detail__right {
                    float: right;
                    font-size: 18px;
                }
            }

            .propertyitem h2 {
                font-size: 1.3125em;
                font-weight: normal;
            }
                    .propertyitem .image {
                    
                }
                .propertyitem p {
                    /*font-size:0.875em!important;*/
                    margin: 0;
                }
                .propertyitem h3 {
                    font-family:'amplitude-bookregular';
                    font-size:0.875em;
                    text-transform:uppercase;
                    margin-bottom:1em;
                    width:50%;
                    color:#3a3a3a;
                }
                .propertyitem h3.right {
                    text-align:right;
                }
            .propertymarker {
                width:450px;
            }
            .propertymarker .image {
                padding:1.25em;
                float:left;
            }
            .propertymarker .desc {
                margin:0 0 0 123px;
                padding:1.25em 0;
            }
            .propertymarker .desc h2,
            .propertymarker .desc h2 a {
                    font-size:21px!important;
                    font-weight: normal;
                }
                .propertymarker .desc p {
                    font-size:14px!important;
                    margin: 0;
                }
                .propertymarker .desc h3 ,
                .propertymarker .desc .links a,
                .propertymarker .desc .links span {
                    font-family:'amplitude-bookregular';
                      font-size:14px!important;
                    font-weight:normal;
                    text-transform:uppercase;
                }
                .propertymarker .desc h3 {
                    font-weight: normal;
                    margin-bottom:10px;
                    width:50%;
                    color:#3a3a3a;
                }
                .propertymarker .desc h3.right {
                    text-align:right;
                }
            #property-detail .top {
                margin: 0 auto;
                max-width: 60em;
                min-width: 18.75em;
                padding: 0 0.625em 0.625em;
            }
            #property-detail .back {
                font-size:0.875em;
                line-height: 3.1429em;
                    font-family:'amplitude-bookregular';
                    text-transform:uppercase;
                  
                border-top: 1px solid #d7d7d7;
                border-bottom: 1px solid #d7d7d7;
                margin-bottom:2.5em;
            }
            #property-detail .info {
                border-top: 1px solid #d7d7d7;
                border-bottom: 1px solid #d7d7d7;
                padding-top:1.25em;
                margin-bottom:1.25em;
            }
                #property-detail .info .bordered {
                    border-bottom: 1px solid #d7d7d7;
                    padding-bottom:1.25em;
                }
                #property-detail .info ul li {
                    list-style-type: disc;
                    list-style-position: inside;
                    margin-left: 1em;
                }

                #property-detail .info th,
                #property-detail .info td {
                font-family:'amplitude-bookregular';
                    padding:0.5em 0.5em 0.5em 0;
                }
                #property-detail .info th {
                    text-align:left;
                }
            #property-detail h1 {
                font-size:2.25em;
            }
            #property-detail h3 {
                font-size:1.5em;
                margin-bottom:0.5833em;
            }
            #property-detail h4 {
                font-size:1.125em;
                color:#707070;
            }
            #property-detail #main p {
                font-family:'amplitude-bookregular';
            }
            #main.home .contactus .bggreen li,
            #property-detail .contactus .bggreen li {
                font-size:1.5em;
                line-height:1.5em;
            }
            .property a,
            .propertymarker a,
            .propertyitem a,
            #property-detail a {
                color: #1d1d1b;
            }
            .property a:hover,
            #property-detail a:hover {
                text-decoration:underline;
            }
            .property-article h2,
            .property-other h2 {
                    font-size:1.3125em!important;
                }
                .property-article h3,
                .property-other h3 {
                    font-family:'amplitude-bookregular';
                    font-size:0.875em!important;
                    text-transform:uppercase;
                    margin-bottom:1em!important;
                    color:#3a3a3a;
                }
                  .property-other h3{  
                        width:50%;
                }
                .property-other h3.right {
                    text-align:right;
                }

            .CMSSiteMapList .CMSSiteMapListItem {
                list-style-type: none;
                margin-bottom:0.8em;
            }
            .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapLink {

                font-weight: bold;
                text-decoration: none;
            }
            .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapLink:hover {
                text-decoration: underline;
            }
            .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapList .CMSSiteMapListItem {
                list-style-type: disc;
                list-style-position: inside;
                margin-left: 1em;
            }
            .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapLink {
                color: #707070;
                font-weight: normal;
                text-decoration: none;
            }
            .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapList .CMSSiteMapListItem .CMSSiteMapLink:hover {
                text-decoration: underline;
            }

            .outerwrap .container {
            float:left;
            position:relative;
            left:50%;
            }
            .outerwrap .center {
            float:left;
            position:relative;
            left:-50%;
            }
            .outerwrap {
            position:relative;
            overflow:hidden;
            } 

            .imageHeadlineWrap {
                position:relative;
                        text-align: center;
                    color:#fff;
            }
            .imageHeadlineWrap img
            {
              display:block;
            }
                .imageHeadlineWrap .centered {
                       vertical-align:middle;
                    position:absolute;
                    top:33%;
                    left:0;
                     width: 100%;
                     padding:0 12%;
                }

            .imageHeadlineWrap a {
                color: #fff;
                text-decoration: none;
            }
              .imageHeadlineWrap h2 {
                    font-size: 3em;
                    font-weight: normal;
                    margin-bottom: 0.3em;
                }


                .imageHeadlineWrap p {
                    font-size: 1.125em; 
                }

            .padbot {
              padding-bottom: 40px;
              }

            .padtop {
              padding-top: 40px;
              }
            .social_share{
            border-top: 1px solid #d7d7d7;
            border-bottom: 1px solid #d7d7d7;
              padding:6px 0;
              margin:0 10px 15px 10px;
              }
            .social_share > a,
            .social_share > label{
            line-height:24px;
            }
            .social_share > label{
            text-transform:uppercase;
              font-size: 0.875em;
            }
            .gr-av-new{
              color:#1a7462;
              }
            .gr-av-underoffer{
              color:#993300;
              }
            .gr-icon32-link {
                line-height:32px;
            }
            .gr-icon-link {
                line-height:24px;
            }
            li.gr-icon-link {
                margin-bottom:8px;
            }

            .CookieConsent {
                font-size: 0.875em;
                text-align: center;
                padding: 0.5em 0;
                background-color:#fff;
            }

            .gr-icon32,
            .gr-icon,
            .a2a_grosvenor .a2a_img,
            .a2a_grosvenor2 .a2a_img{
                display: inline-block;
                text-indent: -99999px;
                overflow: hidden;
                background-repeat: no-repeat;
                background-image: url(http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/icon-set.gif);
                width:24px;
                height:24px;
                vertical-align:middle;
                margin-right:8px;
            }
            .a2a_grosvenor2 .a2a_img{
              margin-right:0;
              }
            .gr-icon32 {
                width:32px;
                height:32px;
            }
            .gr-icon-left{
               background-image: url(http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/left.png);
               background-position:center;
            }
            .gr-icon-close{
               background-image: url(http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/close.png);
               background-position:center;
            }
            .gr-icon-phone {
                background-position:-8px -9px;
            }
            .gr-icon32.gr-icon-phone  {
                background-position:-6px -44px;
            }

            .gr-icon-pencil {
                background-position:-44px -9px;
            }
            .gr-icon32.gr-icon-pencil  {
                background-position:-54px -44px;
            }

            .gr-icon-envelope {
                background-position:-78px -9px;
            }
            .a2a_grosvenor2 .a2a_i_email,
            .gr-icon-envelope2  {
                background-position:-74px -138px!important;
            }
            .gr-icon-envelope3{
               background-image: url(http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/envelope3.png);
               background-position:center;
            }
            .gr-icon32.gr-icon-envelope  {
                background-position:-100px -44px;
            }

            .gr-icon-download {
                background-position:-112px -9px;
            }
            .gr-icon-search {
                background-position:-144px -9px;
            }
            .gr-icon-list {
                background-position:-146px -48px;
            }
            .gr-icon-list2 {
                background-position:-172px -139px;
            }
            .a2a_grosvenor .a2a_i_twitter,
            .gr-icon-twitter  {
                background-position:-121px -90px!important;
            }
            .a2a_grosvenor2 .a2a_i_twitter,
            .gr-icon-twitter2  {
                background-position:-34px -138px!important;
            }
            .gr-icon32.gr-icon-twitter  { 
                background-position:-7px -85px;
            }
            .a2a_grosvenor .a2a_i_facebook,
            .gr-icon-facebook  {
                background-position:-90px -90px!important;
            }
            .a2a_grosvenor2 .a2a_i_facebook,
            .gr-icon-facebook2  {
                background-position:-4px -138px!important;
            }
            .gr-icon32.gr-icon-facebook  {
                background-position:-53px -83px;
            }
            .gr-icon-map  {
                background-position:-142px -137px;
            }
            .gr-icon-map2  {
                background-position:-109px -138px;
            }


            #search-results .result{
                border-bottom:1px solid #D7D7D7;margin: 1.25em;padding-bottom:1.25em;
            }
            #search-results .result:last-child{
                border-bottom:none;
            }
            #search-results .pager{
                border-top:1px solid #D7D7D7;
                padding: 1.25em;
            }
            #search-results .pager .links{
              width:75%;
              margin:0 auto;
              text-align:center;
              line-height: 1.8571em;
            }

            .newsletter_chronicle .bggreen {
                padding: 10px;
            }
            .newsletter_chronicle .button{
             background-color: #1e9e84;
              }
            .newsletter_chronicle .textbox{
            width:100%;
              height: 26px;
              border:none;
              font-size:14px;
              }
            .newsletter_chronicle label{
              line-height:26px;
              font-family:'new_century_schoolbookroman';
              }

            .newsletter h3{
              color:#1d1d1b;
              margin-bottom:15px;
              }
            .newsletter .textbox{
            width:100%;
              height: 26px;
              font-size:14px;
              margin-bottom:15px;
              }
            #directoryleft .newsletter{border-bottom: 1px solid #D7D7D7;}
            .validator{font-size:0.875em; color:red;}
            .newsletter .validator{display: inline-block;
                float: right;
                width: 50%;margin-top:-3px;}

            .newsletter_chronicle .validator{display: inline-block;}

            .chronicle-nav #subnav{border-bottom:1px solid #D7D7D7;}
            .chronicle-nav a.current-issue{
              position:absolute;
              left:0.625em;
              top:30%;
              color:#1d1d1b;
              font-size:0.875em;    text-transform: uppercase;    z-index:8;
              }
            .chronicle-nav a.current-issue span{
            width:16px;
              height:9px;
             background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/down.png') 0 0 no-repeat;
              text-indent:-9999px;
                  display: inline-block;    vertical-align: middle;    overflow: hidden;
              margin-left:8px;
              }

            .chronicle-nav a.current-issue.active span{

             background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/up.png') 0 0 no-repeat;

              }
            .chronicle-carousel{
              height:398px;
              overflow:hidden;
              background-color:#1d1d1b;
              display:none;
                  position: relative;
              }
            .chronicle-carousel .vcarousel-wrap{
            position:relative;
             margin: 0 auto;
                max-width: 60em;
                min-width: 18.75em;
              }
            .chronicle-carousel .vrow{

             padding: 10px 0;
              }

            .chronicle-carousel .vclose{
              margin-top:10px;
              text-align:right;
              }
            .chronicle-carousel .vclose a span{
            width:18px;
              height:18px;
             background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/close_dark.gif') 0 0 no-repeat;
              text-indent:-9999px;
                  display: inline-block;    vertical-align: middle;    overflow: hidden;
              }
            .chronicle-carousel .next{
            background-color: rgba(29, 29, 27, 0.5);
            display: block;
            height: 15%;
            width: 100%;
            bottom: 0;
            left: 0;
            position: absolute;
              }
            /*#Print#*/
            @media print {
            }


            /*#Media#*/
            @media only screen and (max-width : 37.5em) /*600*/
            {
                html {
                    font-size: 87.5%; /*14px*/
                }

                #bottommenu {
                    border-top: 1px solid #d7d7d7;
                    padding: 0;
                }

                   
                    #bottommenu > ul li {
                        display: block;
                        width: 100%;
                        background: #fff;
                        border-bottom: 1px solid #d7d7d7;
                    }
                        #footermenu > ul li a,
                        #bottommenu > ul li a {
                            padding: 1.0714em 0.7143em;
                margin:0;
                color: #1D1D1B;
                        }
                   
                    #bottommenu li ul {
                        display: none;
                    }
             #footermenu > ul li {
                        display: block;
                        width: 100%;
                        background: #fff;
                    }
                #footermenu {
                border-top: none;
                    padding:0;
                    margin:0;
                border-bottom: 1px solid #D7D7D7;
                }
                #footermenu > ul > li + li:before{
                content:'';
                float:none
                  
                }
                #footerlogo {
                    display: block;
                    padding: 1.25em;
                    width: 100%;
                    text-align: center;
                }
              
              
              
              .carouselWrapper  .prev,
              .carouselWrapper .next,
              #home-carousel .item p{
               display:none!important;
            }

            #home-carousel .item {margin: 0 10px;}
              
              #home-carousel .item .centered{position:relative; width:100%; background-color:#fff;color:#000000;padding-top:10px; border-bottom:1px solid #d7d7d7;}
              #home-carousel .item h2{font-size:1.5em;}
              
              #home-carousel .item a {
                color: #000;
                text-decoration: none;
            }
              
              
              .amenity .map{display:none;}
              .amenity .desc{margin-right:0;}
              .property .image{float:none;}
              .property .image img{min-width:100%;}
            .property .desc {
                margin-left: 0;
                padding: 0 1.25em 1.25em 1.25em;
            }
              
              .newsletter_chronicle .grid-65 {padding:0 0 10px 0;}
              #property-carousel .item {margin: 0 10px;}
              #property-carousel .thumbsBg {display:none;}
              #property-tabs {padding:0 10px;}
              
              #directory .top .viewas .gr-icon{margin-right: 0!important;}
              
              #directory .top .viewas a.list, 
              #directory .top .viewas a.map {
                  padding: 7px 0 8px;
              }
              #property-tabs {margin-top:0}
            }  
            @media screen and (max-width: 47.9375em) {
                .maxheight {
                    height: auto!important;
                }
            }

            @media only screen and (max-width : 54.375em) /*870*/ 
            {
                #header {
                    padding: 0 10px 50px;
                }

                #header > .inner {
                    margin: 0;
                    padding: 10px 0 2px;
                    width: 100%;
                }
                #header h1 {
                    max-width: 170px;
                    display: inline-block;
                    float: none;
                }

                #header h1 img{
                    width:100%;
                }
                #header h2 {
                    display: none;
                }

                #topmenuElem {
                    border-bottom: 10px solid #1A7462;
                }

               #search {
                    width: 100%;
                    position:relative;
                }


                /*#search:not( :target ) > a:first-of-type,
                #search:target > a:last-of-type {
                    display: block;
                }*/

                #search > a {
                    display: block;
                    border: 1px solid #D7D7D7;
                    width: 31px;
                    height: 31px;
                    text-align: left;
                    text-indent: -9999px;
                    position: absolute;
                    top: -40px;
                    right: 10px;
                    z-index: 10;
                }
                
                .nav__menu.is-active,
                #topmenuElem.is-active,
                .searchBox-wrap.is-active,
                .search__search.is-active {
                    display: block!important;
                }

                #topmenuElem,
                #search .searchBox-wrap {
                    position: absolute;
                    width: 100%;
                    top: 0;
                    left: 0;
                    z-index: 10;
                }

                .search__search {
                    right: 51px!important;
                }

                .search__search {
                    margin-right: 0;
                }

                .search__divider {
                    display: none;
                }

                .search__twitter {
                    margin-left: 0;
                }

                #search > .searchBox-wrap {
                    display: none;
                }

                #search:target > .searchBox-wrap {
                    display: block;
                }

            #search .searchBox input.textbox, #search .searchBox input.textbox:focus {width:100%;}

            #nav {
                    padding-right:0;
                padding-bottom:0.625em;
                position:relative;
                }
                    #nav > a {
                        display: block;
                        border: 1px solid #D7D7D7;
                        width: 31px;
                        height: 31px;
                        text-align: left;
                        text-indent: -9999px;
                        position: absolute;
                        top: -40px;
                        left: 10px;
                    }

                    .nav__menu {
                        background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/menu-icon.png') no-repeat center;
                    }

                    .nav__menu.is-active {
                        background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/cross.png') no-repeat center;
                    }

                    #topmenuElem {
                        border-top: 1px solid #d7d7d7;
                    }



                    /*#nav:not( :target ) > a:first-of-type,
                    #nav:target > a:last-of-type {
                        display: block;
                    }*/


                    /* first level */
                    #nav > ul {
                        height: auto;
                        display: none;
                    }

                    #nav:target > ul {
                        border-top: 1px solid #d7d7d7;
                        display: block;
                    }

                    #nav > ul > li {
                        width: 100%;
                        float: none;
                        background-color: #fff;
                    }

                        #nav > ul > li > a {
                            height: auto;
                            text-align: left;
                            margin: 0;
                            padding: 0 0.7143em;
                        }

                    #nav ul li > a {
                        border-bottom: 1px solid #d7d7d7;
                    }


                    /* second level */

                    #nav li ul {
                        position: static;
                        padding-top: 0;
                    }

                    #nav > ul:not( :hover ) > li.HighLighted > a{
                        border-bottom: 1px solid #D7D7D7;
                    }
            }

            @media only screen and (min-width: 54.375em) /* 870 */
            {
                #nav {
                    padding-right: 0;
                    width: auto;
                }

                #nav > ul > li > a {
                    font-size: 14px;
                    padding: 0 10px;
                    margin: 0;
                }

                #nav > ul > li + li:before {
                    content: "" | "";
                    float: left;
                    font-size: 0.875em; /* 14 */
                    line-height: 2.74286em; /* 44 (14) */
                    color: #a7a7a7;
                }
                #nav > ul > li:hover:before {
                   display:none;
                }
                #nav > ul > li:first-child > a {
                    margin-left: 10px;
                }

                #nav > ul > li:first-child > ul a {
                    padding-left: 0.7142857142857143em;
                }

                .search-is-open #nav li:hover ul {
                    display: none;
                }

                #search {
                    float: right;
                    position: static;
                }

                #search > a {
                    display: block;
                }

                #search .searchBox-wrap {
                    display: none;
                    position: absolute;
                    left: 0;
                    width: 100%;
                    z-index: 10;
                    padding: 20px 10px 40px 10px;
                    top: 44px;
                }

                #search .searchBox-wrap input.submit {
                    top: 10px;
                    right: 10px;
                }

                .searchBox-wrap.is-active,
                .search__search.is-active {
                    display: block!important;
                }

                .search__search,
                .search__twitter {
                    float: left;
                }

                #search .searchBox {
                    max-width: 780px;
                    margin: 0 auto;
                    position: relative;
                }

                .overlay-nav {
                    display: none;
                }
            }

            @media only screen and (min-width : 37.5em) and (max-width: 51.25em) /* 820px */
            {
                    html {
                    font-size: 87.5%; /*14px*/
                }
              
                .masonry .grid3 {
                    width: 100%;
                }
                
            }

            /* listing */

            .listing-item {
                margin-bottom: 20px;
                padding: 0 10px;
            }

            .listing-item__inner {
                background-color: #fff;
            }

            .listing-item__figure img {
                display: block;
                width: 100%;
            }

            .listing-item__details {
                padding: 20px;
            }

            .listing-item__category {
                margin-bottom: 10px;
                text-transform: uppercase;
            }

            .listing-item__heading {
                margin-bottom: 10px;
            }

            .listing-item--LeftImage .listing-item__inner {
                overflow: hidden;
            }

            .listing-item--LeftImage .listing-item__figure,
            .listing-item--LeftImage .listing-item__details {
                float: left;
                width: 50%;
            }

            .listing-item--Text .listing-item__figure {
                display: none;
            }

            .listing-item--Video .listing-item__video-link {
                display: block;
                position: relative;
            }

            .listing-item--Video .listing-item__video-link:before {
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/play.png') center no-repeat;
                content: '';
                height: 90px;
                left: 50%;
                margin-left: -45px;
                margin-top: -45px;
                position: absolute;
                top: 50%;
                width: 90px;
            }

            .listing-ctas {
                text-align: center;
                padding: 0 10px;
            }

            .listing-ctas__btn {
                background: #707070;
                border: none;
                color: #fff;
                font-family: 'amplitude-bookregular';
                font-size: 17px;
                padding: 15px 55px;
                text-transform: uppercase;
                display: inline-block;
            }

            .listing-ctas__btn.is-disabled {
                background: transparent;
                color: #1d1d1b;
                cursor: default;
            }

            .no-js .listing-ctas__btn {
                display: none;
            }

            .listing-ctas__btn:hover {
                opacity: .9;
            }

            .listing-header {
                border-bottom: 1px solid #d7d7d7;
                margin-bottom: 15px;
                padding-bottom: 15px;
            }

            .listing-header .newsletter_chronicle label {
                font-size: 16px;
            }

            .listing-header .newsletter_chronicle .textbox {
                padding: 12px 100px 12px 10px;
                height: 40px;
            }

            .listing-header .newsletter_chronicle .button {
                padding: 6px 10px;
                font-size: 15px;
                height: 40px;
            }

            .listing-filter__label {
                font-size: 15px;
                font-family: 'new_century_schoolbookroman';
                display: block;
                line-height: 26px;
            }

            .listing-filter__inner {
                padding: 0 10px;
            }

            .listing-filter__inner .bggreen {
                padding: 10px;
            }

            .select {
                background: #F6F6F6;
                cursor: pointer;
                z-index: 1;
                position: relative;
            }

            .select select {
                cursor: pointer;
                position: relative;
                z-index: 2;
                width: 100%;
                height: 40px;
                padding: 10px;
                background: none;
                border-radius: 0;
                border: none;
                font-size: 15px;
                text-indent: 0.01px;
                text-overflow: '';
                -webkit-appearance: none;
                -moz-appearance: none;
                -ms-appearance: none;
                -o-appearance: none;
                appearance: none;
            }

            .select:after {
                background: #F6F6F6;
                color: #C8C8C8;
                content: '\25BE';
                height: 100%;
                position: absolute;
                pointer-events: none;
                right: 0;
                top: 0;
                width: 22px;
                z-index: 0;
                padding-top: 10px;
                box-sizing: border-box;
            }

            .lt-ie10 .select:after {
                display: none;
            }

            :-moz-any( .select ):after {
                z-index: 1;
            }


            @media only screen and (max-width : 37.5em) {
                .listing-header .newsletter_chronicle {
                    margin-bottom: 20px;
                }

                .listing-header .newsletter_chronicle .button {
                    float: right;
                    margin-top: -40px;
                    position: relative;
                }

                .listing-header .newsletter_chronicle .grid-65 {
                    padding-bottom: 0;
                }

                .listing-item {
                    width: 100%;
                }

                .listing-ctas__btn {
                    width: 100%;
                }
            }

            @media only screen and (min-width : 37.5em) {
                .listing-header .newsletter_chronicle .grid-25 {
                    width: 100%;
                }

                .listing-header .newsletter_chronicle .grid-65 {
                    padding-left: 0;
                    width: 65%;
                    width: calc( 100% - 88px );
                    float: left;
                }

                .listing-header {
                    overflow: hidden;
                }

                .listing-header .newsletter_chronicle {
                    width: 67.5%;
                    float: left;
                }

                .listing-filter {
                    width: 32.5%;
                    float: left;
                }

                .listing-item {
                    float: left;
                    width: 50%;
                }

                .listing-item__heading {
                    margin-bottom: 30px;
                }
            }

            .social {
                display: block;
                text-align: center;
                padding: 30px 20px;
            }

            .social:focus .social__icon,
            .social:hover .social__icon {
                background-position: bottom left
            }

            .social.twitter {
                background-color: #64a8de;
                color: #fff
            }

            .social.twitter:focus,
            .social.twitter:hover {
                background-color: #4c92c9;
                text-decoration: none;
            }

            .social__follow,
            .social__when {
                display: block;
                text-transform: uppercase;
            }

            .social__when {
                font-family: 'amplitude-mediumregular';
                font-weight: bold;
            }

            .social__follow {
                font-size: 19px;
                margin-top: 20px;
                margin-right: 5px;
                display: inline-block;
            }

            .social__heading--header {
                padding-top: 20px
            }

            .social__heading--header h2 {
                font-size: 21px
            }

            .social__description {
                font-size: 16px;
                padding-top: 20px;
            }

            .social__description p {
                font-family: 'amplitude-lightregular';
                letter-spacing: .1em;
                line-height: 1.4666em
            }

            .social__description a {
                display: none
            }

            .social__description strong {
                display: none
            }

            .icon--arrow-light {
                display: inline-block;
                zoom: 1;
                vertical-align: middle;
                margin-top: -2px;
                margin-right: 2px;
                overflow: hidden;
                font-style: normal;
                background: url('http://www.grosvenorlondon.com/App_Themes/MayfairBelgravia/images/arrow-light.png') no-repeat 0 0;
                margin-top: -2px;
                width: 24px;
                height: 24px;
            }

            .listing-header .newsletter_chronicle .button:hover {
              color: #1a7462;
              background: #ebebeb;
              }

            #quote-carousel .carouselWrapper,
            #quote-carousel .caroufredsel_wrapper {
                max-width: none;
            }

            #quote-carousel .carouselWrapper > .prev,
            #quote-carousel .carouselWrapper > .next {
                top: 50%;
                margin-top: -16px;
            }

            .quoteitem {
                text-align: center;
              width: 100%;
            }

            .quoteitem__inner {
                padding: 30px 60px;
            }

            .quoteitem__subheading {
                width: 100%!important;
            }

            .quoteitem__heading {
                margin-bottom: 15px;
            }

            .quoteitem__img {
                border-radius: 100%;
                margin-bottom: 10px;
              max-width: 150px;
            }

            .quoteitem__quote {
                max-width: 640px;
                margin-left: auto;
                margin-right: auto;
            }

            .quoteitem__quote:before,
            .quoteitem__quote:after {
                display: inline-block;
                font-size: 1em;
                line-height: 1em;
                    }

            .side-layout-widget-area .box {
              width: 100%!important;
              padding: 0;
              }

            .side-layout-widget-area * + .box {
              margin-top: 20px;
              }";


            UnsemanticBase = @"@media screen and (max-width: 400px) {
              @-ms-viewport {
                width: 320px;
            }
            }
            .clear {
              clear: both;
              display: block;
              overflow: hidden;
              visibility: hidden;
              width: 0;
              height: 0;
            }

            .grid-container:before, .clearfix:before,
            .grid-container:after,
            .clearfix:after {
              content: ""."";
              display: block;
              overflow: hidden;
              visibility: hidden;
              font-size: 0;
              line-height: 0;
              width: 0;
              height: 0;
            }

            .grid-container:after, .clearfix:after {
              clear: both;
            }

            .grid-container, .clearfix {
              /* <IE7> */
              *zoom: 1;
              /* </IE7> */
            }

            .grid-container {
              margin-left: auto;
              margin-right: auto;
              max-width: 1200px;
            }

            .grid-5, .mobile-grid-5, .grid-10, .mobile-grid-10, .grid-15, .mobile-grid-15, .grid-20, .mobile-grid-20, .grid-25, .mobile-grid-25, .grid-30, .mobile-grid-30, .grid-35, .mobile-grid-35, .grid-40, .mobile-grid-40, .grid-45, .mobile-grid-45, .grid-50, .mobile-grid-50, .grid-55, .mobile-grid-55, .grid-60, .mobile-grid-60, .grid-65, .mobile-grid-65, .grid-70, .mobile-grid-70, .grid-75, .mobile-grid-75, .grid-80, .mobile-grid-80, .grid-85, .mobile-grid-85, .grid-90, .mobile-grid-90, .grid-95, .mobile-grid-95, .grid-100, .mobile-grid-100, .grid-33, .mobile-grid-33, .grid-66, .mobile-grid-66 {
              -webkit-box-sizing: border-box;
              -moz-box-sizing: border-box;
              box-sizing: border-box;
              padding-left: 10px;
              padding-right: 10px;
              /* <IE7> */
              *padding-left: 0;
              *padding-right: 0;
              /* </IE7> */
            }
            .grid-5 > *, .mobile-grid-5 > *, .grid-10 > *, .mobile-grid-10 > *, .grid-15 > *, .mobile-grid-15 > *, .grid-20 > *, .mobile-grid-20 > *, .grid-25 > *, .mobile-grid-25 > *, .grid-30 > *, .mobile-grid-30 > *, .grid-35 > *, .mobile-grid-35 > *, .grid-40 > *, .mobile-grid-40 > *, .grid-45 > *, .mobile-grid-45 > *, .grid-50 > *, .mobile-grid-50 > *, .grid-55 > *, .mobile-grid-55 > *, .grid-60 > *, .mobile-grid-60 > *, .grid-65 > *, .mobile-grid-65 > *, .grid-70 > *, .mobile-grid-70 > *, .grid-75 > *, .mobile-grid-75 > *, .grid-80 > *, .mobile-grid-80 > *, .grid-85 > *, .mobile-grid-85 > *, .grid-90 > *, .mobile-grid-90 > *, .grid-95 > *, .mobile-grid-95 > *, .grid-100 > *, .mobile-grid-100 > *, .grid-33 > *, .mobile-grid-33 > *, .grid-66 > *, .mobile-grid-66 > * {
              /* <IE7> */
              *margin-left: expression((!this.className.match(/grid-[1-9]/) && this.currentStyle.display === ""block"" && this.currentStyle.width === ""auto"") && ""10px"");
              *margin-right: expression((!this.className.match(/grid-[1-9]/) && this.currentStyle.display === ""block"" && this.currentStyle.width === ""auto"") && ""10px"");
              /* </IE7> */
            }

            .grid-parent {
              padding-left: 0;
              padding-right: 0;
            }

            iframe, object, embed {
            max-width: 100%;
            }";
        }
    }
}
