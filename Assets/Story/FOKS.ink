EXTERNAL wait(time)

VAR trigger_big_stone_visits = 0
VAR trigger_beyound_big_stone_visits = 0

-> start

=== start ===
#disableInput
Кто я?
Где я?
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
->DONE 




