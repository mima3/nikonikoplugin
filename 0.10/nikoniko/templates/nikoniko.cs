<?cs include "header.cs" ?>
<?cs include "macros.cs" ?>


<script src="<?cs var:chrome.href?>/nn/js/prototype.js" type="text/javascript"></script>
<script src="<?cs var:chrome.href?>/nn/js/tooltip-v0.1.js" type="text/javascript"></script>

<?cs each:user = users ?>
   <?cs each:day = days ?>
   		<div class="tooltip" id="tooltip_<?cs var:user ?>_<?cs var:day ?>" style="display: none;">
			<?cs var:comment_data[user][day] ?>           			
   		</div>
   <?cs /each ?>
<?cs /each ?>

<form action="<?cs var:nikoniko.href ?>" method="get">
<div id="content" class="nikoniko">

 <h1>やる夫カレンダー</h1>
 <?cs if:can_change == 1?>
 	 <div id="personal">
		 <div id="yourMood">
		   <h2>あなたの気分</h2>
		   <div id="moodText">
		    ようこそ <?cs var:username?>さん,今日の調子はどうです?
		   </div>
		   <ul id="moodList">
		    <li <?cs if:todays_mood == 'worstMood'?>id="active"<?cs /if?>><a href="?worstMood"><img src="<?cs var:chrome.href?>/nn/images/worstMood.png" alt="Worst" title="最悪･･･"/></a></li>
		    <li <?cs if:todays_mood == 'badMood'?>id="active"<?cs /if?>><a href="?badMood"><img src="<?cs var:chrome.href?>/nn/images/badMood.png" alt="Bad" title="よくない"/></a></li>
		    <li <?cs if:todays_mood == 'okMood'?>id="active"<?cs /if?>><a href="?okMood"><img src="<?cs var:chrome.href?>/nn/images/okMood.png" alt="Ok" title="まぁまぁ"/></a></li>
		    <li <?cs if:todays_mood == 'goodMood'?>id="active"<?cs /if?>><a href="?goodMood"><img src="<?cs var:chrome.href?>/nn/images/goodMood.png" alt="Good" title="いいかんじ"/></a></li>
		    <li <?cs if:todays_mood == 'bestMood'?>id="active"<?cs /if?>><a href="?bestMood"><img src="<?cs var:chrome.href?>/nn/images/bestMood.png" alt="Best" title="最高！"/></a></li>
		   </ul>
		 </div>
		 <div id="yourComment">
		    <h2>Comment</h2>
		    <div id="commentText">
		       なにか理由があるならどうぞ。
		    </div>
		 	<textarea name="comment" rows="3" columns="25"><?cs var:comment ?></textarea>
		    <div id="commentButtons">
		 		<input type="submit" value="Submit"/>
		 	</div>
		 </div>
	  </div>
 <?cs /if ?>

 <div id="teamMood">
   <h2>チームの雰囲気</h2>   
   <div id="calendarText">
      Week Starting <a href="?date=<?cs var:last_week ?>">&lt;&lt</a>&nbsp;<?cs var:start_of_week?>&nbsp;<a href="?date=<?cs var:next_week ?>">&gt;&gt</a>
   </div>
   <table border="0" cellpadding="0" cellspacing="0">
      <thead>
         <tr>
            <td class="username">&nbsp;</td>
            <?cs each:day = days ?>
               <td><?cs var:day ?></td>
            <?cs /each ?>
         </tr>
      </thead>
      <tbody>
         <?cs each:user = users ?>
            <tr>
               <td class="username">
                  <?cs var:user ?>
               </td>
               <?cs each:day = days ?>
                  <td id="day_<?cs var:user ?>_<?cs var:day ?>">
                      <?cs if:mood_data[user][day] == 'worstMood'?><img src="<?cs var:chrome.href?>/nn/images/worstMood.png" alt="最悪･･･"/><?cs /if ?>
                      <?cs if:mood_data[user][day] == 'badMood'?><img src="<?cs var:chrome.href?>/nn/images/badMood.png" alt="よくない"/><?cs /if ?>
                      <?cs if:mood_data[user][day] == 'okMood'?><img src="<?cs var:chrome.href?>/nn/images/okMood.png" alt="まぁまぁ"/><?cs /if ?>
                      <?cs if:mood_data[user][day] == 'goodMood'?><img src="<?cs var:chrome.href?>/nn/images/goodMood.png" alt="いいかんじ"/><?cs /if ?>
                      <?cs if:mood_data[user][day] == 'bestMood'?><img src="<?cs var:chrome.href?>/nn/images/bestMood.png" alt="最高！"/><?cs /if ?>
                      <?cs if:mood_data[user][day]?><A href="#">コメント<SPAN class=setumei><?cs var:comment_data[user][day] ?></SPAN></A><?cs /if ?>
                  </td>
               <?cs /each ?>
	    </tr>
         <?cs /each ?>
      </tbody>
    </table>
 </div>

</div>
</form>


 
<?cs include "footer.cs" ?>
