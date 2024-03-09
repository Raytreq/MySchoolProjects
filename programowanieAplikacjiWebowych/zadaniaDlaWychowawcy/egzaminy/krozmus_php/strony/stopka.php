<div class="stopka">
    <h3>Krzysiek Rozmus 3TP | 25.05.2023r | Liczba odwiedzin: 9001 | <a href="https://corgiorgy.com/" target="_blank">Strona Autora</a> | Przeglądarka: 
        <?php
            // zapożyczona i lekko edytowana funkcja ( ͡° ͜ʖ ͡°)
            function get_browser_name($user_agent)
            {
                if (strpos($user_agent, 'Opera') || strpos($user_agent, 'OPR/')) return 'Opera';
                elseif (strpos($user_agent, 'Edge')) return 'Microsoft Edge';
                elseif (strpos($user_agent, 'Chrome')) return 'Google Chrome';
                elseif (strpos($user_agent, 'Safari')) return 'Safari';
                elseif (strpos($user_agent, 'Firefox')) return 'Mozilla Firefox';
                elseif (strpos($user_agent, 'MSIE') || strpos($user_agent, 'Trident/7')) return 'Internet Explorer';
                return 'Other';
            }
            
            echo get_browser_name($_SERVER['HTTP_USER_AGENT']);
        ?>
    </h3>
</div>