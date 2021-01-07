var amChartsMapsDemo={init:function(){var t,e;t="M9,0C4.029,0,0,4.029,0,9s4.029,9,9,9s9-4.029,9-9S13.971,0,9,0z M9,15.93 c-3.83,0-6.93-3.1-6.93-6.93S5.17,2.07,9,2.07s6.93,3.1,6.93,6.93S12.83,15.93,9,15.93 M12.5,9c0,1.933-1.567,3.5-3.5,3.5S5.5,10.933,5.5,9S7.067,5.5,9,5.5 S12.5,7.067,12.5,9z",e="m2,106h28l24,30h72l-44,-133h35l80,132h98c21,0 21,34 0,34l-98,0 -80,134h-35l43,-133h-71l-24,30h-28l15,-47",AmCharts.makeChart("m_amcharts_1",{type:"map",theme:"light",dataProvider:{map:"worldLow",zoomLevel:3.5,zoomLongitude:-55,zoomLatitude:42,lines:[{id:"line1",arc:-.85,alpha:.3,latitudes:[48.8567,43.8163,34.3,23],longitudes:[2.351,-79.4287,-118.15,-82]},{id:"line2",alpha:0,color:"#000000",latitudes:[48.8567,43.8163,34.3,23],longitudes:[2.351,-79.4287,-118.15,-82]}],images:[{svgPath:t,title:"پاریس",latitude:48.8567,longitude:2.351},{svgPath:t,title:"تورنتو",latitude:43.8163,longitude:-79.4287},{svgPath:t,title:"لوس آنجلس",latitude:34.3,longitude:-118.15},{svgPath:t,title:"هاوانا",latitude:23,longitude:-82},{svgPath:e,positionOnLine:0,color:"#000000",alpha:.1,animateAlongLine:!0,lineId:"line2",flipDirection:!0,loop:!0,scale:.03,positionScale:1.3},{svgPath:e,positionOnLine:0,color:"#585869",animateAlongLine:!0,lineId:"line1",flipDirection:!0,loop:!0,scale:.03,positionScale:1.8}]},areasSettings:{unlistedAreasColor:"#8dd9ef"},imagesSettings:{color:"#585869",rollOverColor:"#585869",selectedColor:"#585869",pauseDuration:.2,animationDuration:2.5,adjustAnimationSpeed:!0},linesSettings:{color:"#585869",alpha:.4},export:{enabled:!0}}),function(){var t="M9,0C4.029,0,0,4.029,0,9s4.029,9,9,9s9-4.029,9-9S13.971,0,9,0z M9,15.93 c-3.83,0-6.93-3.1-6.93-6.93S5.17,2.07,9,2.07s6.93,3.1,6.93,6.93S12.83,15.93,9,15.93 M12.5,9c0,1.933-1.567,3.5-3.5,3.5S5.5,10.933,5.5,9S7.067,5.5,9,5.5 S12.5,7.067,12.5,9z";AmCharts.makeChart("m_amcharts_2",{type:"map",theme:"light",dataProvider:{map:"worldLow",zoomLevel:3.5,zoomLongitude:-20.1341,zoomLatitude:49.1712,lines:[{latitudes:[51.5002,50.4422],longitudes:[-.1262,30.5367]},{latitudes:[51.5002,46.948],longitudes:[-.1262,7.4481]},{latitudes:[51.5002,59.3328],longitudes:[-.1262,18.0645]},{latitudes:[51.5002,40.4167],longitudes:[-.1262,-3.7033]},{latitudes:[51.5002,46.0514],longitudes:[-.1262,14.506]},{latitudes:[51.5002,48.2116],longitudes:[-.1262,17.1547]},{latitudes:[51.5002,44.8048],longitudes:[-.1262,20.4781]},{latitudes:[51.5002,55.7558],longitudes:[-.1262,37.6176]},{latitudes:[51.5002,38.7072],longitudes:[-.1262,-9.1355]},{latitudes:[51.5002,54.6896],longitudes:[-.1262,25.2799]},{latitudes:[51.5002,64.1353],longitudes:[-.1262,-21.8952]},{latitudes:[51.5002,40.43],longitudes:[-.1262,-74]}],images:[{id:"london",svgPath:t,title:"لندن",latitude:51.5002,longitude:-.1262,scale:1},{svgPath:t,title:"Brussels",latitude:50.8371,longitude:4.3676,scale:.5},{svgPath:t,title:"Prague",latitude:50.0878,longitude:14.4205,scale:.5},{svgPath:t,title:"Athens",latitude:37.9792,longitude:23.7166,scale:.5},{svgPath:t,title:"Reykjavik",latitude:64.1353,longitude:-21.8952,scale:.5},{svgPath:t,title:"دیوبلین",latitude:53.3441,longitude:-6.2675,scale:.5},{svgPath:t,title:"اسلو",latitude:59.9138,longitude:10.7387,scale:.5},{svgPath:t,title:"لیسبون",latitude:38.7072,longitude:-9.1355,scale:.5},{svgPath:t,title:"مسکو",latitude:55.7558,longitude:37.6176,scale:.5},{svgPath:t,title:"بلگراد",latitude:44.8048,longitude:20.4781,scale:.5},{svgPath:t,title:"براتیسلاوا",latitude:48.2116,longitude:17.1547,scale:.5},{svgPath:t,title:"لیوبلیانا",latitude:46.0514,longitude:14.506,scale:.5},{svgPath:t,title:"مادرید",latitude:40.4167,longitude:-3.7033,scale:.5},{svgPath:t,title:"استکهلم",latitude:59.3328,longitude:18.0645,scale:.5},{svgPath:t,title:"برن",latitude:46.948,longitude:7.4481,scale:.5},{svgPath:t,title:"کیف",latitude:50.4422,longitude:30.5367,scale:.5},{svgPath:t,title:"پاریس",latitude:48.8567,longitude:2.351,scale:.5},{svgPath:t,title:"نیویورک",latitude:40.43,longitude:-74,scale:.5}]},areasSettings:{unlistedAreasColor:"#FFCC00",unlistedAreasAlpha:.9},imagesSettings:{color:"#CC0000",rollOverColor:"#CC0000",selectedColor:"#000000"},linesSettings:{arc:-.7,arrow:"middle",color:"#CC0000",alpha:.4,arrowAlpha:1,arrowSize:4},zoomControl:{gridHeight:100,draggerAlpha:1,gridAlpha:.2},backgroundZoomsToTop:!0,linesAboveImages:!0,export:{enabled:!0}})}(),AmCharts.makeChart("m_amcharts_3",{type:"map",theme:"light",projection:"miller",dataProvider:{map:"worldLow",getAreasFromMap:!0},areasSettings:{autoZoom:!0,selectedColor:"#CC0000"},smallMap:{},export:{enabled:!0,position:"bottom-right"}}),function(){var t="M9,0C4.029,0,0,4.029,0,9s4.029,9,9,9s9-4.029,9-9S13.971,0,9,0z M9,15.93 c-3.83,0-6.93-3.1-6.93-6.93S5.17,2.07,9,2.07s6.93,3.1,6.93,6.93S12.83,15.93,9,15.93 M12.5,9c0,1.933-1.567,3.5-3.5,3.5S5.5,10.933,5.5,9S7.067,5.5,9,5.5 S12.5,7.067,12.5,9z",e="M19.671,8.11l-2.777,2.777l-3.837-0.861c0.362-0.505,0.916-1.683,0.464-2.135c-0.518-0.517-1.979,0.278-2.305,0.604l-0.913,0.913L7.614,8.804l-2.021,2.021l2.232,1.061l-0.082,0.082l1.701,1.701l0.688-0.687l3.164,1.504L9.571,18.21H6.413l-1.137,1.138l3.6,0.948l1.83,1.83l0.947,3.598l1.137-1.137V21.43l3.725-3.725l1.504,3.164l-0.687,0.687l1.702,1.701l0.081-0.081l1.062,2.231l2.02-2.02l-0.604-2.689l0.912-0.912c0.326-0.326,1.121-1.789,0.604-2.306c-0.452-0.452-1.63,0.101-2.135,0.464l-0.861-3.838l2.777-2.777c0.947-0.947,3.599-4.862,2.62-5.839C24.533,4.512,20.618,7.163,19.671,8.11z";AmCharts.makeChart("m_amcharts_4",{type:"map",theme:"light",dataProvider:{map:"worldLow",linkToObject:"london",images:[{id:"london",color:"#000000",svgPath:t,title:"لندن",latitude:51.5002,longitude:-.1262,scale:1.5,zoomLevel:2.74,zoomLongitude:-20.1341,zoomLatitude:49.1712,lines:[{latitudes:[51.5002,50.4422],longitudes:[-.1262,30.5367]},{latitudes:[51.5002,46.948],longitudes:[-.1262,7.4481]},{latitudes:[51.5002,59.3328],longitudes:[-.1262,18.0645]},{latitudes:[51.5002,40.4167],longitudes:[-.1262,-3.7033]},{latitudes:[51.5002,46.0514],longitudes:[-.1262,14.506]},{latitudes:[51.5002,48.2116],longitudes:[-.1262,17.1547]},{latitudes:[51.5002,44.8048],longitudes:[-.1262,20.4781]},{latitudes:[51.5002,55.7558],longitudes:[-.1262,37.6176]},{latitudes:[51.5002,38.7072],longitudes:[-.1262,-9.1355]},{latitudes:[51.5002,54.6896],longitudes:[-.1262,25.2799]},{latitudes:[51.5002,64.1353],longitudes:[-.1262,-21.8952]},{latitudes:[51.5002,40.43],longitudes:[-.1262,-74]}],images:[{label:"پروازها از لندن",svgPath:e,left:100,top:45,labelShiftY:5,color:"#CC0000",labelColor:"#CC0000",labelRollOverColor:"#CC0000",labelFontSize:20},{label:"نمایش پروازها از ویلنیوس",left:106,top:70,labelColor:"#000000",labelRollOverColor:"#CC0000",labelFontSize:11,linkToObject:"vilnius"}]},{id:"vilnius",color:"#000000",svgPath:t,title:"ویلنیوس",latitude:54.6896,longitude:25.2799,scale:1.5,zoomLevel:4.92,zoomLongitude:15.4492,zoomLatitude:50.2631,lines:[{latitudes:[54.6896,50.8371],longitudes:[25.2799,4.3676]},{latitudes:[54.6896,59.9138],longitudes:[25.2799,10.7387]},{latitudes:[54.6896,40.4167],longitudes:[25.2799,-3.7033]},{latitudes:[54.6896,50.0878],longitudes:[25.2799,14.4205]},{latitudes:[54.6896,48.2116],longitudes:[25.2799,17.1547]},{latitudes:[54.6896,44.8048],longitudes:[25.2799,20.4781]},{latitudes:[54.6896,55.7558],longitudes:[25.2799,37.6176]},{latitudes:[54.6896,37.9792],longitudes:[25.2799,23.7166]},{latitudes:[54.6896,54.6896],longitudes:[25.2799,25.2799]},{latitudes:[54.6896,51.5002],longitudes:[25.2799,-.1262]},{latitudes:[54.6896,53.3441],longitudes:[25.2799,-6.2675]}],images:[{label:"پروازها از ویلنیوس",svgPath:e,left:100,top:45,labelShiftY:5,color:"#CC0000",labelColor:"#CC0000",labelRollOverColor:"#CC0000",labelFontSize:20},{label:"نمایش پرواز ها از لندن",left:106,top:70,labelColor:"#000000",labelRollOverColor:"#CC0000",labelFontSize:11,linkToObject:"لندن"}]},{svgPath:t,title:"بروکسل",latitude:50.8371,longitude:4.3676},{svgPath:t,title:"پراگ",latitude:50.0878,longitude:14.4205},{svgPath:t,title:"آتن",latitude:37.9792,longitude:23.7166},{svgPath:t,title:"ریکیاویک\n",latitude:64.1353,longitude:-21.8952},{svgPath:t,title:"دیوبلین",latitude:53.3441,longitude:-6.2675},{svgPath:t,title:"اسلو",latitude:59.9138,longitude:10.7387},{svgPath:t,title:"لیسبون",latitude:38.7072,longitude:-9.1355},{svgPath:t,title:"مسکو",latitude:55.7558,longitude:37.6176},{svgPath:t,title:"بلگراد",latitude:44.8048,longitude:20.4781},{svgPath:t,title:"براتیسلاوا",latitude:48.2116,longitude:17.1547},{svgPath:t,title:"لیوبلیانا",latitude:46.0514,longitude:14.506},{svgPath:t,title:"مادرید",latitude:40.4167,longitude:-3.7033},{svgPath:t,title:"استکهلم",latitude:59.3328,longitude:18.0645},{svgPath:t,title:"برن",latitude:46.948,longitude:7.4481},{svgPath:t,title:"کیف",latitude:50.4422,longitude:30.5367},{svgPath:t,title:"پاریس",latitude:48.8567,longitude:2.351},{svgPath:t,title:"نیویورک",latitude:40.43,longitude:-74}]},areasSettings:{unlistedAreasColor:"#FFCC00"},imagesSettings:{color:"#CC0000",rollOverColor:"#CC0000",selectedColor:"#000000"},linesSettings:{color:"#CC0000",alpha:.4},balloon:{drop:!0},backgroundZoomsToTop:!0,linesAboveImages:!0,export:{enabled:!0}})}(),AmCharts.makeChart("m_amcharts_5",{type:"map",theme:"light",dataProvider:{map:"worldHigh",zoomLevel:3.5,zoomLongitude:10,zoomLatitude:52,areas:[{title:"Austria",id:"AT",color:"#67b7dc",customData:"1995",groupId:"before2004"},{title:"Ireland",id:"IE",color:"#67b7dc",customData:"1973",groupId:"before2004"},{title:"Denmark",id:"DK",color:"#67b7dc",customData:"1973",groupId:"before2004"},{title:"Finland",id:"FI",color:"#67b7dc",customData:"1995",groupId:"before2004"},{title:"Sweden",id:"SE",color:"#67b7dc",customData:"1995",groupId:"before2004"},{title:"Great Britain",id:"GB",color:"#67b7dc",customData:"1973",groupId:"before2004"},{title:"Italy",id:"IT",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"France",id:"FR",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"Spain",id:"ES",color:"#67b7dc",customData:"1986",groupId:"before2004"},{title:"Greece",id:"GR",color:"#67b7dc",customData:"1981",groupId:"before2004"},{title:"Germany",id:"DE",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"Belgium",id:"BE",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"Luxembourg",id:"LU",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"Netherlands",id:"NL",color:"#67b7dc",customData:"1957",groupId:"before2004"},{title:"Portugal",id:"PT",color:"#67b7dc",customData:"1986",groupId:"before2004"},{title:"Lithuania",id:"LT",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Latvia",id:"LV",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Czech Republic ",id:"CZ",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Slovakia",id:"SK",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Slovenia",id:"SI",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Estonia",id:"EE",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Hungary",id:"HU",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Cyprus",id:"CY",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Malta",id:"MT",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Poland",id:"PL",color:"#ebdb8b",customData:"2004",groupId:"2004"},{title:"Romania",id:"RO",color:"#83c2ba",customData:"2007",groupId:"2007"},{title:"Bulgaria",id:"BG",color:"#83c2ba",customData:"2007",groupId:"2007"},{title:"Croatia",id:"HR",color:"#db8383",customData:"2013",groupId:"2013"}]},areasSettings:{rollOverOutlineColor:"#FFFFFF",rollOverColor:"#CC0000",alpha:.8,unlistedAreasAlpha:.1,balloonText:"[[title]] joined EU at [[customData]]"},legend:{width:"100%",marginRight:27,marginLeft:27,equalWidths:!1,backgroundAlpha:.5,backgroundColor:"#FFFFFF",borderColor:"#ffffff",borderAlpha:1,top:450,left:0,horizontalGap:10,data:[{title:"EU member before 2004",color:"#67b7dc"},{title:"Joined at 2004",color:"#ebdb8b"},{title:"Joined at 2007",color:"#83c2ba"},{title:"Joined at 2013",color:"#db8383"}]},export:{enabled:!0}}),AmCharts.makeChart("m_amcharts_6",{type:"map",theme:"light",colorSteps:10,dataProvider:{map:"usaLow",areas:[{id:"US-AL",value:4447100},{id:"US-AK",value:626932},{id:"US-AZ",value:5130632},{id:"US-AR",value:2673400},{id:"US-CA",value:33871648},{id:"US-CO",value:4301261},{id:"US-CT",value:3405565},{id:"US-DE",value:783600},{id:"US-FL",value:15982378},{id:"US-GA",value:8186453},{id:"US-HI",value:1211537},{id:"US-ID",value:1293953},{id:"US-IL",value:12419293},{id:"US-IN",value:6080485},{id:"US-IA",value:2926324},{id:"US-KS",value:2688418},{id:"US-KY",value:4041769},{id:"US-LA",value:4468976},{id:"US-ME",value:1274923},{id:"US-MD",value:5296486},{id:"US-MA",value:6349097},{id:"US-MI",value:9938444},{id:"US-MN",value:4919479},{id:"US-MS",value:2844658},{id:"US-MO",value:5595211},{id:"US-MT",value:902195},{id:"US-NE",value:1711263},{id:"US-NV",value:1998257},{id:"US-NH",value:1235786},{id:"US-NJ",value:8414350},{id:"US-NM",value:1819046},{id:"US-NY",value:18976457},{id:"US-NC",value:8049313},{id:"US-ND",value:642200},{id:"US-OH",value:11353140},{id:"US-OK",value:3450654},{id:"US-OR",value:3421399},{id:"US-PA",value:12281054},{id:"US-RI",value:1048319},{id:"US-SC",value:4012012},{id:"US-SD",value:754844},{id:"US-TN",value:5689283},{id:"US-TX",value:20851820},{id:"US-UT",value:2233169},{id:"US-VT",value:608827},{id:"US-VA",value:7078515},{id:"US-WA",value:5894121},{id:"US-WV",value:1808344},{id:"US-WI",value:5363675},{id:"US-WY",value:493782}]},areasSettings:{autoZoom:!0},valueLegend:{right:10,minValue:"little",maxValue:"a lot!"},export:{enabled:!0}})}};jQuery(document).ready(function(){amChartsMapsDemo.init()});