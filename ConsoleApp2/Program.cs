﻿// Get data

Console.WriteLine("Enter data: (empty input = prefilled data)");
string data = Console.ReadLine() ?? ""; // if input is null, use empty string

// If no data is entered, use prefilled data
if (data.Length == 0)
{
    data =
        "404310113342042430523206553054613026452223317713352040314520532034136044035422242052404520323121423120022131035104020413264056552251024207112052153646716635163015540126546334604634352130343204203212114444043404350333465355412140536532335724647116565610572546474626506052303052063065052530351012030212240414554223531015555065165021520410363021033163304514155663733352116600665403462501544352500033324144130111224105125305614015103771206061460425505011635353313773273343325122626415203015344311232113245430241150240464126012614135430370003075735010164413125456766205302613425655024334411031155403441245002130523346005210411662277072426351216071200446765701447237330324567025204602342520044502121214045553122025654652221354616163561012500762010384874262074144065234401637722263412266464251452314420554052436551160102504245073471242400253801258004372606111667766236046654353552356241642235535400230444034403653045355316273427144521155460537330375254634265217831710133466511570022515061342332314215330305636623403455371527067601715250678103470620507380025232122252031461570076036342312211025412152531154664324333510065716166433534816054420634864077383448250450766671674224724566465113516230555214332343546262452365454705617472281546633211772075171047360414071436550632720021764434561305210301111443005611044613477737043746056557178022072372401206038184673647422320773366100676006211551510212133313521334520014277727658110473505777283286103991788280475205774027243280366061162025220015443455155404252050544375401645717463634684248661783289138494563725362778686756122861113531553244022156404101264441110131756443257557872335606716942314559648922296471179061870856246756574324520340610552502552345216103355364312158072306454410946149736569151493634487672710443362287688034427626033035266435032116136355447236216431376728258285654613995348237354962282338329733408310145842020562245054642441224363655451243141363087456580326751652471257429153117112342588642859256252141665722503521125022565203656402177710126565314466702484652152875481365818345352121487714962821315157703464343750046056642556042122224622324270101114885994351144861589211656115175234527658398149331284812500044434453264665333402317273401421323318415855844499641764213948757537893227517242385296970317342824206711503004500341045445002443367084450562962259886574728664877676766689484955395194385797583863611332250124025511530441155216276525375870173389743919985448259629562325456237285529598688811050240824703721074602060320021441136216827813607342916845194696625696785568454728524752386544154132864251748117643644612016356236015127477502168551236473444979246675949449587984562945859468987964451443376640177554302403555521032161450418348764563917129159623593365988455562286236885389659621188427923285451742156213351116161327255665606701821864175493119539272489637754729983857664245665796727199928145136462257620362465324256011240774073378929732467468357478524626995373968674237767743387885552216853467388044247756643342275312602047038565615877434724873572784389557789777857693948752846554139723438258054200025014665051242516637708146638198373275222758924486548779744574439965559638384373152521363134036477637737533643152555635778437871298236855485688298578349488385645847564753765967563925377954286572876073532255052252355510464443878597562686999366353446874577654743895687373779864325297372128203202721414431575003626454683627045725543215594452394956436955758673339474559874959389629573279978978206522053161354627516237702078544682942119397343558584845947957956986767739349699889797692213624665730454802067156200457151510133551651137637224323537736454384779467644967339586954746668462789875763614758041306350335154370506881211537946276895249658859666595888979499974679997597784647296794417997582782381025574417013603706282285595672445598476844553485594594694865577988599545878778554434654896767653370600163151076753567166396584462282676939868463579768879699478585698835334464668886671938943507604626741055316424603540766436474549593426596456855354984858479546978868766769885893482223982736645038024543705004215748043040351658449499986735473677885875695647795765956883964888467568526739498861211513560376277541056808037332121324298298467888439897499685669789559864468637637659443647357982947036001076457301501750655275336942638945358964763536465468989488667796645858846573465972686416787340853151245644712676410408042175645992725856638455389978885467555675756857577896385395967245722641824067046404672127263578732604583334129426765554856475867757556696788664596649687355745252374587569983167874135470372567082480204357437552435378439546954796599589886886999448548554873566373887522667838861416626063504053336576743468622556295365645349984889785678558796559694969799447958394395964464961434514564147064634031154473874813798648457894764786965996797567598577449556796733655629459883126531875350855667400242382466736377478123774763774843994888788596767997699956676943467867843525339987287625323107646574363428370183567442332638863797996446594766875586998755697498794589458457898531351415551433522556412167557672308712367589426397979758975789888776586986996554696687355758873775853874897420702317101770303703378804536976332878328747387584568459887597696678765458466869646823658768383568726667515101452233157246118285247999798264378649666585777768676869779576767654376979948352929633336613662437752445720367378533569416697754293496373467957556998785966978548459859767957423835655379853826412537652743314715884636853952588482996464655775879867757788958998964888966363788982234644268286248732605364421252340411081749754123523897998635856478675875579877695848758757598799352859935972592464121200154240060534144421235633966383826944588955556569877797756857998594637769364656894472644372534212151333030406408132303595787173445575575686448657959549968444868588895645466777395756386243943041550563144273114334761050642652349846942498578754978859865947785499768464999467827979546133588431400553072571545140256541065084978642274659978546685549897854997987959494546787556536925383718147440765477035264213551156551872738118554524476466757347767578664548796858878373885346253453663631131187832513353720031302225003187455433275258559853476398764745884957978785699446894568423546775622669458815340346707622067430504086108575211657573256737949367744989999457768543933556446848583667956928715425470730162242111564658304088777519536233444248435478893367596684875833738467857765957226924427228481325217576364055473230737526383625952385867723976677963779587753646766774437577338682519314383352032477133503321304645532064452197673316923724578983475574649393989787463485775923766996461422676353215802454115233105015700144131749152169592849597799334664843639757588555464399727868723189114371617811204424461200116461554525361612654498296559659356483355845588365383658756592935783639172813284867400343573434063667611325433422432889612288938865635845895684777885359355942764253445159748552521586663111276320602227464555468655756429585352455445365885785394937349896765628578363566623445953670505237256637361565061226117741561827365137945864958743698627664964883854386585344264536463794276685706331233201162022104543457075344433186746554898622888662879483534875732366545699493494249416960261188772111451356436620604222365732527426815953936962792895744565572436255439745543587676567692850112721235162354066131524412733104587364628695894553856954929535227798584623638988936368718849285573225440174764501540542435561362065510830610739646131257342496749563278998673868857392617956152266780580611770145235126403602071007077303754367568233894922487258962426625788335236293726841614813262288087316403413301325653365633721421431240238511233988284565865357732839935658824268124333235971843281322245237465244640306442137750441441547377231538498282333378867895866774269433657996442236932105133474315101276433026026362613577242456258634050671963436933444863559863424588962566983574869370120588454323506304034454324415624033560610606167505705335537131257342423913353449125925341756615871358508731521557026114366444331064667665623244155236812366396427328522481655365283852878951317624280585607560532023416160531356100663130344012403254770320017162464663432371564992618187659799885888814177114132251720346235260335255502200627412653317161700362276552642826696514719212976746877872577501286045667131741121615252432342461115176570456177856545043415022291419917157172495246595828707718465323075462216735351424603052014513044443630413221560860665817858636725794462229844935048786680202681024216170152252502634130020320466436640542335164431658623622013245024685776848188641088056885388363367731111662103514422342243313636453126262451331254501288620001007675817755413767166283281358125642646705337503156330264143322052011503256425407127570260816542455843672731851386601352556410113100252536057366522542640013024122243505446640664755657664365330525660042002157156113773258264460845541635501120634115505113335223400325240315062161366031440416477741684364564857378773141186841270761406731633364031611642530523212033035153153462216052744630367426463087060858055232515783208471176613722677126341566006053644200442235202335236553544540304237444375273744171216804617062750281644425671760635002322246613220112112312424551125551101552103143451563560236361153202606118476772167626160624534653670012136420410040115003433115113101302300404521334255672566234211040710503455555073775502462316364453256460002143312311050113231445145014641142635155170110005103066306721236312425606163376276006132006331601341420241440202124001123533434316253543204160331101266365020140476416102251147360064153500112411356634011134351330004034442142153246064264662030666771573157310340000724745700036734054206654603230345313434140344030321402405400252420216445132115124427151235102635446313422013474177203430646340442422400002232222342";
}

TreeFinder treeFinder = new TreeFinder(data);

// fill array with zeroes
treeFinder.FillArrayWithZeroes();

// load map
treeFinder.LoadMap();

// write map
treeFinder.WriteMap();

// print available trees 
Console.WriteLine("Available trees: " + treeFinder.AvailableTrees);
