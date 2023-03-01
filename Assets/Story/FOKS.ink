EXTERNAL wait(time)
EXTERNAL wait_melody(name)
EXTERNAL set_form(id)
EXTERNAL cutscene_owl()

VAR trigger_big_stone_visits = 0
VAR trigger_beyound_big_stone_visits = 0
VAR trigger_after_fear_visits = 0
VAR trigger_end_visits = 0
VAR trigger_owl_visits = 0
VAR trigger_fear_visits = 0

-> start

=== start ===
'Кто я? ~~~Нажмите "T"~~~ '
Где я?#disableInput
Что это такое вокруг?
#enableInput
~wait(2)
'*** Осмотритесь изпользуя W, D и ПРОБЕЛ ***'
Отлично, оказывается вокруг столько интересного
Правда мне здесь все равно не нравится
Да и изнутри какая-то странная пустота...
#hide
-> DONE
=== trigger_big_stone===
{ trigger_big_stone_visits == 1:
И КТО ОСТАВИЛ ЗДЕСЬ ЭТОТ БОЛЬШОЙ КАМЕНЬ?
Кругом сплошные препятствия в итак не очень дружелюбном мире...
Кстати, о дружелюбии, вот бы с кем нибудь подружиться...
'*** думаю стоит продолжать двигаться ***'
} #hide
->DONE 

=== trigger_beyound_big_stone===
{ trigger_beyound_big_stone_visits == 1:
Хе, это было совсем не сложно
Оказывается я достаточно ловкий, значит со мной точно будет интересно и я буду полезен!
'*** хоть вокруг и темно, я что-то вижу впереди, надо бежать посмотреть! ***'
} #hide
{ trigger_beyound_big_stone_visits > 1:
Идти дальше, не оглядываясь!
} #hide
->DONE 

=== trigger_owl===
{ trigger_owl_visits == 1:
#disableInput
О, привет
~ cutscene_owl()
Странное создание: УХУ - УХУ
Стой куда-ты... #enableInput
} #hide
->DONE 

=== trigger_fear===
{ trigger_fear_visits == 1:
AAAAAAAAAAAAAAAAAAA, БЕЖАТЬ
} #hide
->DONE 


=== trigger_after_fear ===
{trigger_after_fear_visits ==1:
ЧТО ЭТО БЫЛО #disableInput
'*** лисенок попытался хоть как-то справится с окружающей его темнотой'
'и вспомнил мелодию из глубин своей души'
'попробуйте наиграть её, используя клавиши NumPad'
~ wait_melody("owl_melody")
'Подсказка: 0 5 6 4 5'
Отлично!
~ set_form(1)
ЧТО ПРОИЗОШЛО?
Почему я могу летать?
Не важно
Зато теперь я смогу улететь от этого страшного..
злобного...
ужасного...
ААААААААААААА #enableInput
} #hide
->DONE


=== trigger_end ===
{trigger_end_visits ==1:
~ set_form(0)
#disableInput
Я снова вижу себя лисенком! Ура) 
И этот свет кажется совсем не злобный, в отличие от тех глазков ночи...
БРРРРР
Но почему я вижу еще кого-то...
Мне кажется если я подойду поближе...
#enableInput
КОНЕЦ ПЕРВОЙ ГЛАВЫ
} #hide
->DONE



