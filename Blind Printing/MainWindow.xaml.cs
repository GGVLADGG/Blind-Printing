using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Blind_Printing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string pass_to_file = @".\Best result.txt";
        public static int old_information_file = 0;
        public static DispatcherTimer timer = new DispatcherTimer();
        public static bool Is_Timer_Hidden = true;
        public static int c1 = 0;
        public static int c10 = 0;
        public static string What_Language = "";
        public static int elements = 0;
        public static int what_element = 0;
        public static int pass_for_element = 0;
        public static string letter = "";
        public static double word_count = 0;
        public static bool able_to_print = false;
        public static string old_text = "";
        public static bool pass_to_mistake = true;
        public static double mistakes = 0;
        public static double result = 0;
        public static string new_result = "";
        public static string first_text_ru = "", second_text_ru = "", third_text_ru = "", fourth_text_ru = "", fifth_text_ru = "";
        public static string sixth_text_ru = "", seventh_text_ru = "", eighth_text_ru = "", ninth_text_ru = "", tenth_text_ru = "";
        public static string first_text_ua = "", second_text_ua = "", third_text_ua = "", fourth_text_ua = "", fifth_text_ua = "";
        public static string sixth_text_ua = "", seventh_text_ua = "", eighth_text_ua = "", ninth_text_ua = "", tenth_text_ua = "";
        public static string first_text_en = "", second_text_en = "", third_text_en = "", fourth_text_en = "", fifth_text_en = "";
        public static string sixth_text_en = "", seventh_text_en = "", eighth_text_en = "", ninth_text_en = "", tenth_text_en = "";
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            old_information_file = Convert.ToInt32(File.ReadAllText(pass_to_file));
            if (old_information_file != 0)
            {
                Best_result.Text = "Best result: " + Convert.ToString(old_information_file);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            c1 += 1;
            if (c1 > 9)
            {
                c1 = 0;
                c10 += 1;
                if (c10 == 6)
                {
                    New_Some_Text.Text = "";
                    timer.Stop();
                    Button_Start.IsEnabled = true;
                    elements = 0;
                    what_element = 0;
                    pass_for_element = 0;
                    letter = "";
                    able_to_print = false;
                    old_text = "";
                    pass_to_mistake = true;
                    result = 0;
                    new_result = "";
                    if (word_count > mistakes)
                    {
                        result = 100 - mistakes * 100 / word_count;
                    }
                    else
                    {
                        result = 0;
                    }
                    new_result = Convert.ToString(result);
                    if (new_result.Length > 4)
                    {
                        new_result = new_result.Remove(new_result.Length - new_result.Length + 4);
                    }
                    if (word_count >= old_information_file)
                    {
                        File.WriteAllText(pass_to_file, Convert.ToString(word_count));
                        Best_result.Text = Convert.ToString(word_count);
                    }
                    result = Convert.ToDouble(new_result);
                    MessageBox.Show("Time is over!\nYour accuracy: " + result + "%\nWord count: " + word_count + "\nMistakes: " + mistakes);
                }
            }
            Timer_text.Text = Convert.ToString(c10) + Convert.ToString(c1);
        }
        private void Click_Russian(object sender, RoutedEventArgs e)
        {
            What_Language = "Russian";
        }
        private void Click_Ukrainian(object sender, RoutedEventArgs e)
        {
            What_Language = "Ukrainian";
        }
        private void Click_English(object sender, RoutedEventArgs e)
        {
            What_Language = "English";
        }
        private void Russian_Text()
        {
            first_text_ru = "Вот и минуло теплое лето. Наступила осень. Незаметно подкралась она к нашим садам, полям, рощам, лесам. " +
                        "Еще в конце августа деревья начали укрываться желтыми листьями, а теперь оно уже блестело на солнце, будто золото. " +
                        "Деревья стояли в багряных, желтых листьях, которые потихоньку спадали наземь. Земля была покрыта цветными листьями, " +
                        "как будто идешь по прекрасном ковре. Я люблю слушать шорохи опавших листьев, смотреть на волшебные росписи осени на " +
                        "листьях клена. Промелькнуло короткое бабье лето, начинало повевать холодом, умолкли пернатые музыканты. " +
                        "Вот и пришло время прощаться с золотой осенью.";
            second_text_ru = "За волшебной тучкой спряталась ночь, и на землю спустилось розовое утро. Вот-вот должно взойти солнце. " +
                "Его лучи уже загораются на горизонте. Ожидают утра все: растения, животные, люди. Только почему же его еще нет? " +
                "Может, еще спит сладким сном? А может, было в ссоре с землей и не хочет больше светить? Что же теперь? " +
                "И все-таки восток постепенно розовеет. Наконец, будто из-под одеяла, взошло над горизонтом солнце, величественное, " +
                "красивое. Быстренько осветило лучом воды, лес, окружающие поля, дома людей. Заискрилась зеленым ковром земля в " +
                "его сиянии. Когда луч солнца дотронулся и до моего лица, я проснулся, весело ему улыбнулся, открыл глаза и радостно " +
                "встретил новый день.";
            third_text_ru = "Больше всего я люблю весну. Это, по-моему, самое прекрасное время года. Весной все на земле просыпается " +
                "к новой жизни. Тает снег, появляется молодая зеленая травка. На деревьях и кустах распускаются листочки. " +
                "Весной возвращаются к нам перелетные птицы: скворцы, грачи, аисты. Они начинают вить гнезда, готовить жилье для " +
                "будущих птенцов. Я люблю наблюдать за весенней природой. Видеть, как все вокруг обновляется, украшается после " +
                "зимнего сна. Весело поют ручейки, на все голоса прославляют приход весны пернатые музыканты. " +
                "Воздух наполняется душистым запахом растений. Весна - это обновление в природе. Именно за это я ее люблю.";
            fourth_text_ru = "Я очень люблю встречать первые вспышки пробуждения нового дня. Задолго до востока солнце извещает о " +
                "своем приходе. Оно окрашивает своими лучами ночной небосклон, гасит зори. Я люблю встречать солнце, игру и " +
                "трепет утренних вспышек его лучей. Сначала на горизонте появляется багряно красная полоса. Потом она становится " +
                "оранжевой, розовой, а дальше солнцем наполнялось все вокруг. И будто впервые видишь зеленый листочек, дерево, " +
                "которое растет вплоть до моего окна, и легкий туман над родным городом, который просыпается до нового дня. " +
                "И вот рассвет изменяется новым днем, наполняется заботами жизни людей, и я слышу нежное: Хорошего утра, сыну!";
            fifth_text_ru = "На картине Екатерины Белокур - замечательные цветы на фоне чистого, погожего неба. Их можно распределить " +
                "на два букета. Один, ближний, находится в тени, второй - более выразительный, светлый, осеняемый солнечными лучами. " +
                "Цветов немного: красный, зеленый, белый, голубой. Но употреблено много промежуточных красок. Я думаю, мастерица " +
                "очень любит природу, безмерно влюбленная в цветы. А их здесь множество. Тянутся к солнцу розовые мальвы. " +
                "По березовой ветви поплелась вьющаяся березка. Очаровывают глаз белоснежные ромашки и оранжевые лилии, розово " +
                "красные тюльпаны и настурция с вишневыми прожилками на лепестках. Картина очаровывает гармонией цветов и форм, " +
                "захватывает красотой и мастерством.";
            sixth_text_ru = "Моими самыми любимыми животными всегда были и останутся собаки. Ни у кого нет таких преданных глаз, " +
                "как у них. Эти верные и смелые существа могут быть и другом для своего хозяина, и защитником, и даже напарником " +
                "в работе. А сколько раз собаки спасали людей, отыскивали их под завалами. Приручив собак, люди получили верных " +
                "спутников и помощников. Рядом с собакой человек никогда не почувствует себя одиноким или никому ненужным. " +
                "Моя мечта – это хаски. Но такую собаку в городе держать сложно, ей необходимо пространство и физические нагрузки. " +
                "Это сильное животное с характером, оно требует от своего хозяина уверенности и смелости. Только в этом случае собака " +
                "будет уважать и слушаться человека. При слове хаски у меня перед глазами сразу же появляется картина: красивый " +
                "заснеженный лес, посреди него дорога, по которой мчится упряжка черно-белых собак.";
            seventh_text_ru = "Все мы прекрасно знаем, что кошки очень умные и своенравные животные. Так можно сказать обо всех из " +
                "породы кошачьих. Но у нас дома живет исключение из правил. С этим котом я познакомилась два года назад. " +
                "Мама и папа подарили мне его на день рождения. Он был очень милым и ласковым котенком. Ночами Филя пробирался ко " +
                "мне в комнату и удобно устраивался на моей шее. Когда мама приходила будить меня в школу, кот начинал топтать меня " +
                "лапками и громко урчать, от этого я быстро просыпалась. Говорят, что все кошки приземляются на лапы, но к моему " +
                "котику это не относится. Он не только часто падает, но и плохо прыгает. Уже не раз мы посещали ветеринара с вывихом " +
                "лап и поврежденными внутренними органами.";
            eighth_text_ru = "Муравьи очень трудолюбивые существа. Они очень маленькие размером , но защищают деревья от насекомых - " +
                "вредителей, поэтому их еще называют санитарами леса. А бывают они разных цветов: серого, коричневого, красного. " +
                "У них шесть лапок, два усики, которые размещены на головке. Они живут большими семьями в больших муравейниках. " +
                "Муравьи - рабочие могут переносить груз в сто раз больший, чем их собственный вес. Пять муравейников могут спасти " +
                "целый гектар леса. Вот почему мы не должны плохо относиться к этим маленьким существам.";
            ninth_text_ru = "На земле нет человека, который бы не слышал что-то об акулах. А когда в 1975 году вышел жуткий фильм " +
                "Стивена Спилберга об этом хищнике, то страх перед акулами вырос еще больше. Ученые-акуловеды пытаются объяснить людям, " +
                "что хотя паника перед огромными монстрами понятная и необходимая, но взаимодействие с ними вполне реальное, если к " +
                "нему верно подойти. Это ветшайшее морское животное, спрятанное под занавесью опасности и загадок. Заинтересованность " +
                "к этой таинственной персоне актуален до нашего времени. Мир науки и сейчас не может прийти к единой мысли о вопросе: " +
                "как на планете появились акулы? Несмотря на численные дискуссии относительно происхождения акул, мировые научные " +
                "круги едины в одном - это доисторический, угрожающий, напористый и чрезвычайно неглупый хищник, познание которого " +
                "не прекращается до сих пор.";
            tenth_text_ru = "Мы живем на планете Земля. В солнечной системе много планет, но по проводимым исследованиям ученых " +
                "считается, что только на Земле созданы все необходимые условия для жизни. Наша планета не самая большая, основную " +
                "ее территорию занимают моря, океаны, реки и озера. Только третья часть планеты считается сухопутной территорией. " +
                "Вокруг нашей планеты вращается привычный для нас спутник – это Луна. Она имеет очень важное значение для жизни на " +
                "планете, регулируя приливы и отливы. Солнце согревает Землю до благоприятных температур. Иначе Земля остынет, и " +
                "все живое погибнет от холода. Планета Земля – это наш родной дом, она прекрасна. Украшением Земли являются леса, " +
                "луга, горы, реки, океаны, моря, пустыни. Везде созданы условия для жизни.";
            string[] massive_ru = new string[] { first_text_ru, second_text_ru, third_text_ru, fourth_text_ru, fifth_text_ru,
                        sixth_text_ru, seventh_text_ru, eighth_text_ru, ninth_text_ru, tenth_text_ru };
            Some_Text.Text = massive_ru[new Random().Next(0, massive_ru.Length)];
        }
        private void Ukrainian_Text()
        {
            first_text_ua = "Сонце котиться на спочинок. Мрійливими стають береги. Принишкли верболози й комиші. Задрімала далечінь. " +
                        "Зрідка крякне десь крижень, закахкає дика качка чи обізветься в лунній тиші деркач. Червонясті заграви освітили " +
                        "небокрай, тихі заплави. Довгоногий чорногуз завмер на зеленому болоті, підсвіченому жовтогарячим призахідним промінням. " +
                        "Тільки-но згас палаючий захід і синьо-зелена оксамитова ніч, гаптована рясним золотом зірок, за ліском на лівобережному " +
                        "пагорбі запалало червоне вогнище. Горів ліс, горіла земля, горіло небо на обрії. Жовтогарячі, рожеві, фіолетові " +
                        "косиці хмар вилискували в зеніті: сходив місяць. А незабаром був уже в небі, прояснілий, золотавий. Йому всміхався " +
                        "другий, з води… Літня ніч коротка. Раптом зашелестіли комиші. Змахнула крилами і знялась у повітря проворна чирка. " +
                        "Сплеснула рибина під берегом. Барвисто займався схід. Із свіжими рум’янцями, з росяною прохолодою по-молодецькому " +
                        "бадьоро зводився ранок.";
            second_text_ua = "Сьогодні в лісі справжній жовтневий листопад. Клени обсипаються від найменшого подиху вітерця. " +
                "Гаснуть осінні вогневі барви. На восковому листі з’являються брудні плями. Деякі листки, засихаючи, скручуються " +
                "в дудочку, і коли обережно розгорнути такий листок, всередині в ньому тремтить кришталева росинка. " +
                "Як же поріділи дерева! Наче довго хтось брів по коліна в опалому листі, в золотому шумі, прийшов і навстіж розчинив " +
                "у лісі тисячу синіх віконець. На тихих галявинах тільки шипшина сміється червоними губами та глід чваниться разками " +
                "коралів.";
            third_text_ua = "Неможливо відвести погляд від різнобарвного вбрання дерев під час неперевершеної малярки-осені. " +
                "Вийдеш в один із останніх кришталевих днів у цю неповторну живу майстерню і мимохіть стишуєш ходу перед вершинними " +
                "витворами природи. Бо хто може передбачити напевне, коли обважнілі осінні хмари надовго закриють стомлене за " +
                "літо сонце і скільки буде дощів, снігів, заморозків, недоречних відлиг, поки натруджена земля не порине у білий сон? " +
                "Поки ще не минула нагода, хочеться намилуватись прозорим, щедро напоєним пахощами, повітрям, чарівливо-таємничим " +
                "торжеством природи. Саме цієї пори вона найбільше вабить до себе, бо стає надивовижу життєдайною. " +
                "Змінюється ніби саме небо, сонце стає менш яскравим і пекучим. Дні стоять надивовижу м’які, і, здається, " +
                "сама природа стає більш спокійною і урівноваженою.";
            fourth_text_ua = "Нині ранком світ став білим-білим. Перший сніг упав на землю. Він найбіліший. " +
                "Сніг цей неначе звучить м’якою, ліричною мелодією. Він пробуджує радість. Зима почалася! " +
                "Після сірих, холодних листопадових дощів - перший здоровий морозець. Сніжинка до сніжинки тчуть сніговий килим. " +
                "Дерева ніби цвітуть. Ясени і клени, берези і горобина, калина і горішина. Усі вони від підніжжя до стовбурів крон " +
                "одяглися в іній. Кожне видається великою квіткою, хай і холодною. Три казкових красуні застигли віддалік над річкою. " +
                "То три верби. їхнє текуче, спадисте гілля особливо густо обнизалось пухким білим снігом. Берізки під снігом здаються " +
                "повітряно-легкими, такі вони світлі і чисті. І все навкруги немов чудернацька картина, де використано лише білий колір.";
            fifth_text_ua = "Якось увечері дмухнув вологий вітер. Цілу ніч він шумів голим виттям, а вранці нагнав густих сірих хмар. " +
                "Потім почався рясний дощ. Він безперестанно йшов цілий день, ущух тільки надвечір, тоді з землі піднявся густий " +
                "сивий туман. Він клубочився молочними хвилями, і на вулицях за три кроки нікого не можна було побачити. Три дні " +
                "змагалось сонце з туманом і хмарами. І, нарешті, перемогло. Радіючи з перемоги, воно приснуло на землю сліпучим " +
                "золотим промінням. І всі зрозуміли, що почалася весна. Небо стало чисте і синє-синє. " +
                "Повітря якось одразу значно потеплішало. За кілька днів у набубнявілих бруньках уже можна було побачити клейкі " +
                "зелені листочки. Вітер був теплий і ласкавий. Здавалось, усі: люди, природа жива і нежива, небо, сонце - раділи з того," +
                " що зима нарешті пішла. Настрій у всіх був піднесений. Радість відчувалась навіть у тому, як по-новому, " +
                "по-весняному цвірінькали горобці, співала синичка. Кудись раптом зникли ворони, що своїм криком досаджали цілу " +
                "довгу холодну зиму, накликаючи сніг.";
            sixth_text_ua = "Великий, грізний житель лісів. Герой багатьох казок та легенд. Все це про нього – ведмедя. " +
                "Один його вигляд змушує тремтіти навіть найхоробріших, а його грізне ревіння приводить до повного оціпеніння тих, " +
                "хто все ж не пустився навтіки при його вигляді. Разом з тим, ведмідь завжди уособлює силу та мудрість, з якою ця " +
                "сила застосовується. До того ж, в багатьох казках він постає справедливим суддєю в суперечках між іншими персонажами. " +
                "Мабуть, це саме завдяки його могутній зовнішності. Коли уявляєш собі ведмедя, то перше, що спадає на думку – це " +
                "його великий зріст, коричневе хутро та люте ревіння, якого усі жахаються. Можна скільки завгодно вважати його " +
                "доброю твариною, але все ж не слід забувати, що він є хижаком. Незважаючи на те, що годується ведмідь загалом " +
                "рослинною їжею – горіхами, ягодами, травами, також до його раціону входять інші тварини, такі як косулі та олені, " +
                "іноді ведмеді нападають на людину. Тому краще все ж зустрічатися з ним в зоопарку, чи на сторінках казок.";
            seventh_text_ua = "Тигр дивує нас своєю грацією і силою. Це дика кішка - швидка і безстрашна, вона є представником хижого " +
                "царства. Ударом лапи тигр може звалити з ніг навіть коня або іншу велику тварину. Довжина тіла тигра становить півтора " +
                "– три метри. Зріст – 120 см. Він має довгий хвіст, що досягає одного метру. Вага тварини становить 300 кг. " +
                "У тигрів розкішна шерсть, в зимовий період вона становить 5 см в довжину на грудях і 10 см на животі. " +
                "Хутро тигра має червонувато-жовтий колір з чорними смугами по всьому тілу. Хоча в природі зустрічаються тигри " +
                "чорного і білого забарвлення. При всій своїй силі, тигр, як і всі тварини сімейства котячих, відрізняється грацією. " +
                "Рухи їх спритні, плавні. Цей звір може рухатися акуратно і безшумно. Як у всіх хижаків у тигра гострий зір, " +
                "відмінний слух і нюх. Він спритно стрибає, лазить по скелях і плаває.";
            eighth_text_ua = "Ми живемо на планеті Земля. У Сонячній системі багато планет, але дослідження вчених свідчать, що " +
                "тільки на Землі створені всі необхідні умови для життя. Наша планета не найбільша, основну її територію займають моря, " +
                "океани, річки та озера. Тільки третина планети вважається сухопутною територією. Навколо нашої планети обертається " +
                "звичний для нас супутник - це Місяць. Він має дуже важливе значення для життя на планеті, регулюючи припливи" +
                " та відливи. Сонце зігріває Землю до сприятливих температур. Інакше Земля охолоне, та все живе загине від холоду. " +
                "Планета Земля - ​​це наш рідний дім, вона неповторна та прекрасна. Окрасою Землі є ліси, луки, гори, річки, океани, " +
                "моря, пустелі. Скрізь створені умови для життя.";
            ninth_text_ua = "Для кожного з нас краса природи пов'язана перш за все з пейзажами рідного краю - того куточка землі, " +
                "де народився, де мамина колискова закарбовується назавжди у пам'яті, серці, душі незабутніми спогадами. " +
                "Неодмінною часткою таких спогадів стає рослинний світ рідного краю. Для одних це білокорі стрункі берізки чи " +
                "тремтливі тендітні тополі, для інших - барвисто уквітчані килими вологих луків чи смарагдове полотно гірських полонин. " +
                "Рослинний світ України вражає багатством і розмаїттям. Називається він одним словом - флора. Була така грецька богиня " +
                "квітів, весни, а також веселощів. Весь рослинний світ України налічує, за даними вчених-ботаніків, чотири з половиною " +
                "тисячі видів! Це не враховуючи водоростей, грибів, лишайників.";
            tenth_text_ua = "Коли пригрівають теплі промені весняного сонця, однією з перших комашок прокидається сонечко. " +
                "Ці комахи здіймаються у повітря, сідають на руки та обличчя людей, повзають рослинними стеблинами та шукають там їжу. " +
                "Сонечко – це яскраво-червона комаха з чорними цяточками. Взимку вона спить у потаємному містечку. " +
                "Так сонечко може пережити зимові холоди. У травні сонечка вже розмножуються: вони відкладають яйця на стеблинах " +
                "та листочках. Маленькі сонечка стають дорослими за два місяці, харчуються вони дрібними комашками, тлями. " +
                "Ця комаха – хижак, проте люди все одно дуже прихильні до неї. Мабуть, за її красу та за це, що вона знищує " +
                "шкідливих комах, які псують садові рослини.";
            string[] massive_ua = new string[] { first_text_ua, second_text_ua, third_text_ua, fourth_text_ua, fifth_text_ua,
                        sixth_text_ua, seventh_text_ua, eighth_text_ua, ninth_text_ua, tenth_text_ua };
            Some_Text.Text = massive_ua[new Random().Next(0, massive_ua.Length)];
        }
        private void English_Text()
        {
            first_text_en = "I am sorry I have not written for such a long time. I have been really busy with my new project. " +
                "By the way, thank you for your brilliant idea. I really had the best presentation last time. I really appreciated your advice. " +
                "As for your question, I think all you have to do is just regular exercises. Dont be lazy and try to find at least " +
                "20-30 minutes for your health every day. There is a rule of 30 minutes a day: if you do something at least 30 minutes " +
                "a day you will have a result at the end of the week. For example, if you read 50 pages during this time, at the end of " +
                "the week you will have total of about 350 pages. If we say that we dont have enough time for it (as we usually do) we have " +
                "0 result at the end of the week. Besides, they say that it takes 21 days to form a new habit. So all you have to do is to " +
                "take the bull by the horns and try it for just 3 weeks.";
            second_text_en = "What is nature? It is a mystery, it is a tale, it is magic as it is. And I think autumn is one of the greatest " +
                "examples of nature magic. If you look at these trees, covered with multicolor leaves - red, orange and still green here " +
                "and there, you will surely agree with me. The leaves are still on the trees but in a few days the fall will begin and all " +
                "the pavements will be covered with a reddish carpet made of leaves. They seem extremely bright because of the sky. In autumn " +
                "it turns grey or sometimes deep blue. This background makes the leaves look bright and fresh. Looking at all the beauty we " +
                "can forget about cold, wind and rain. They say, there is no bad weather, there are bad clothes. Even So rain in autumn is a " +
                "good thing and magic if it is treated as a part of the nature";
            third_text_en = "My name is Irina. I like domestic animals. So, we have rabbits, hens and pigs at home. I help my mother " +
                "to feed them. It is so interesting to watch them! But I have my pet. Its name is Jack. He is friendly and cheerful. " +
                "He likes to look important. He has smooth fur, big eyes and ears. His tail is short. He can sit, dance and give his paw. " +
                "My dog and I are great friends. We spend a lot of time together. It is not difficult for me to take care of my dog. " +
                "I love my dog very much!";
            fourth_text_en = "I have got a cat. Her name is Matilda. She is quite old for a cat. She is eleven years old. " +
                "Matilda is very fluffy. Her back is black and her belly and chest are white. She also has a black muzzle with long " +
                "white whiskers. Her legs and paws are white. Matilda has big eyes. Her eyes are light green, but they become yellow in " +
                "bright sunlight. She has got big black ears and a small pink nose. As any other cat Matilda loves sleeping, eating and " +
                "playing. Her favourite places are an armchair in the living room and a windowsill in my parents 'bedroom. Matilda also " +
                "likes lying on my desk and especially on the computer keyboard! Her favourite food is meat and boiled fish. " +
                "She also likes sour cream, soft cheese and ham. Sometimes we buy cat food and cat grass for her. She has a lot of cat " +
                "toys to play with. She enjoys hunting flies, spiders and sunbeams.";
            fifth_text_en = "Our planet is not the only one in the universe but is supposedly the only one which is inhabited by " +
                "living creatures. We have all the necessary resources to live a happy life: clean water, fresh air, good nature, eatable " +
                "plants. However, during the last century most scientists are worried that nature is under danger. Thus, people and all " +
                "the living creatures that surround us are also endangered. The water in the global ocean is not so clean any more due to " +
                "human reckless actions. Many useful plants are being cut down for creating newer industrial areas. Some animal species are " +
                "disappearing from the surface of the Earth and that is sorrowful. Knowing this, people from all the existing countries " +
                "should remember that we are rather fragile.";
            sixth_text_en = "Ukraine has mostly coniferous and deciduous trees, such as pine, oak, fir, beech and birch. " +
                "The wealth of the forest includes not only timber, but also berries, mushrooms and medical herbs. The animal world of Ukraine " +
                "is different. It has hundreds of species of animals and birds. They are: wolf, fox, badger, deer, elk, hamster, " +
                "field mouse and so on. The birds are: the sparrow, titmouse, grouse, owl. Some fur animals, such as mink, silver-black " +
                "fox, musk-rat, brought into Ukraine have acclimatized well. In the rivers and lakes there are perch, carp. " +
                "The Forest-Steppe zone contains the oak, elm, black poplar, willow, ash and pine. The animals include squirrels, foxes, " +
                "hares and roes. The rivers and lakes are home to ducks, geese, storks and cranes. It should also be said that the animal " +
                "life of the Carpathians is unique. Here you can find deer brown bears, wild cats and pigs, black squirrels. " +
                "Bird life includes golden eagles and black wood peckers. The plants of this region are also different and beautiful. " +
                "It is well worth visiting, especially in spring.";
            seventh_text_en = "Some peoples activities do a lot of harm to the forests. People cut down trees to build houses, roads, " +
                "factories and plants. Deforestation is a very serious environmental problem. The worlds great rainforest are all near " +
                "the equator, in Africa, South America and South-East Asia. These rainforests are homes to millions of kinds of exotic " +
                "animals, birds, reptiles, insects, strange plants and beautiful flowers. Three quarters of the world’s species live in " +
                "the rainforests. If we destroy their habitat many of them will not survive. Amazon rainforest is the biggest and most " +
                "important in South America. Scientists believe that plants from the forest could give us many important new medicines " +
                "such as cures for cancer and AIDS.";
            eighth_text_en = "The tiger is a wild animal. Tigers are the largest wild cats in the world. It looks like a big cat. " +
                "It has a round head, huge body and a long tail. The Royal Bengal tiger has black stripes on its body. Adults can weigh " +
                "up to 363kg and measure up to 3.3m! It lives in a thick forest. It is a beast of prey. It kills sheep, goats, cows, " +
                "deer and men. It hunts in the night and sleeps by day. We find tigers in the zoo and in the circus. " +
                "Tigers are fast dying out from our jungles. So, the Government are now trying to preserve them. There are many kinds of tiger. " +
                "The tiger is a dreadful and strongest animal. At full speed, tigers can reach up to 65km/h.";
            ninth_text_en = "I am going to tell you about my school. My school is new and modern and I like it very much. It has three floors. " +
                "The classrooms are light and spacious. There are classrooms for different subjects, such as English, History, Physics, " +
                "Mathematics, Chemistry, Geography, Biology Literature etc. There is a computer class in our school. We study computer " +
                "science here. The computer class has the most modern equipment and the Internet access. We’ve also an assembly hall, " +
                "which is situated on the second floor. Meetings, conferences, concerts and all the celebrations take place here. " +
                "We prepare different performances for all holidays. We sing songs, recite poetry, dance, and participate in theatre performances.";
            tenth_text_en = "The United Kingdom of Great Britain and Northern Ireland is situated on the British Isles. They lie to the " +
                "north-west of Europe. The British Isles are separated from the continent by the narrow strait of water which is called " +
                "the English Channel. The United Kingdom consists of four parts: England, Scotland, Wales and Northern Ireland. England, " +
                "the central part, occupies the most of the island of Great Britain. To the north lies Scotland and to the west the third " +
                "part of the country, Wales, is situated. The fourth part is called Northern Ireland and is located on the second island. " +
                "Each part has its capital. The capital of England is London, Wales has Cardiff, Scotland has Edinburgh and the main city " +
                "of Northern Ireland is Belfast.";
            string[] massive_en = new string[] { first_text_en, second_text_en, third_text_en, fourth_text_en, fifth_text_en,
                        sixth_text_en, seventh_text_en, eighth_text_en, ninth_text_en, tenth_text_en };
            Some_Text.Text = massive_en[new Random().Next(0, massive_en.Length)];
        }
        private void Click_Start(object sender, RoutedEventArgs e)
        {
            if (What_Language == "")
            {
                MessageBox.Show("Please, choose the language");
            }
            else
            {
                Button_Start.IsEnabled = false;
                able_to_print = true;
                if (What_Language == "Russian")
                {
                    Russian_Text();
                }
                else if (What_Language == "Ukrainian")
                {
                    Ukrainian_Text();
                }
                else if (What_Language == "English")
                {
                    English_Text();
                }
                c1 = 0;
                c10 = 0;
                Timer_text.Text = "00";
                New_Some_Text.Text = "";
                Word_Count.Text = "Word count: ";
                word_count = 0;
                elements = 0;
                what_element = 0;
                pass_for_element = 0;
                mistakes = 0;
                Mistakes.Text = "Mistakes: ";
                timer.Start();
            }
            Warn_Text.Visibility = Visibility.Visible;
        }
        private void Preview_Click_Box(object sender, MouseButtonEventArgs e)
        {
            Warn_Text.Visibility = Visibility.Collapsed;
        }
        private void Text()
        {
            elements = 0;
            what_element = 0;
            foreach (char n in Some_Text.Text)
            {
                elements++;
            }
            string[] en_massive = new string[elements];
            foreach (char n in Some_Text.Text)
            {
                if (n == ' ')
                {
                    en_massive[what_element] = "Space";
                    what_element++;
                }
                else
                {
                    en_massive[what_element] = Convert.ToString(n);
                    what_element++;
                }
            }
            letter = en_massive[pass_for_element];
        }
        private void Preview_Text_Input(object sender, TextCompositionEventArgs e)
        {
            e.Handled = true;
            if (able_to_print == true)
            {
                Text();
                if (e.Text == letter)
                {
                    pass_for_element++;
                    word_count++;
                    Word_Count.Text = "Word count: " + Convert.ToString(word_count);
                    if (pass_to_mistake == false)
                    {
                        if (letter != "Space")
                        {
                            New_Some_Text.Text = New_Some_Text.Text.Remove(New_Some_Text.Text.Length - 1);
                            New_Some_Text.Text += letter;
                        }
                    } 
                    else
                    {
                        New_Some_Text.Text += letter;
                    }
                    pass_to_mistake = true;
                }
                else
                {
                    mistakes++;
                    Mistakes.Text = "Mistakes: " + Convert.ToString(mistakes);
                    if (letter != "Space")
                    {
                        if (pass_to_mistake == true)
                        {
                            pass_to_mistake = false;
                            if (letter != "Space")
                            {
                                old_text = New_Some_Text.Text;
                                New_Some_Text.Text = "";
                                New_Some_Text.Inlines.Add(new Run() { Text = old_text, Foreground = Brushes.LightGreen });
                                New_Some_Text.Inlines.Add(new Run() { Text = letter, Foreground = Brushes.Red, });
                            }
                        }
                    }
                }
            }
        }
        private void Preview_Key_Down(object sender, KeyEventArgs e)
        {
            if (able_to_print == true)
            {
                if (e.Key == Key.Back)
                {
                    e.Handled = true;
                }
                if (e.Key == Key.Space)
                {
                    e.Handled = true;
                    Text();
                    if (letter == "Space")
                    {
                        pass_for_element++;
                        word_count++;
                        Word_Count.Text = "Word count: " + Convert.ToString(word_count);
                        New_Some_Text.Text += " ";
                    }
                }
            }
        }
        private void Click_Stop(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            c1 = 0;
            c10 = 0;
            Timer_text.Text = "00";
            Some_Text.Text = "";
            New_Some_Text.Text = "";
            Button_Start.IsEnabled = true;
            able_to_print = false;
            Word_Count.Text = "Word count: ";
            word_count = 0;
            elements = 0;
            what_element = 0;
            pass_for_element = 0;
            mistakes = 0;
            Mistakes.Text = "Mistakes: ";
            letter = "";
            old_text = "";
            pass_to_mistake = true;
            result = 0;
            new_result = "";
        }
        private void Click_Flag(object sender, RoutedEventArgs e)
        {
            if (Is_Timer_Hidden == true)
            {
                Is_Timer_Hidden = false;
                Invisible_Timer.Visibility = Visibility.Visible;
            }
            else
            {
                Is_Timer_Hidden = true;
                Invisible_Timer.Visibility = Visibility.Hidden;
            }
        }
    }
}
