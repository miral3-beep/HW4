# HW4
## Devlog
The score class in my code handles the control because it has the score data. The code to increase the score when the player passes a pipe is able to reference this through PipeIncreaseScore, since score is a singleton. View would be handled by the Score UI and the AudioManager because they only respond whenever the score changes. Events and Singletons are able to keep view and control aspects decoupled because I have a singleton on my score class. PipeIncreaseScore would be able to trigger a score change by calling score.instance.UpdateScore(). In my code, GameEvents.OnScoreChanged decouples my view from my control because it will fire GameEvents.RaiseScoreChanged(). Since the score text and AudioManager are subscribed to it independently, they will respond, but the score function itself is separate from it. 

## Open-Source Assets
If you added any other assets, list them here!
- [Free Flappy Bird Sprites](https://www.spriters-resource.com/mobile/flappybird/asset/59894/) - background, pipes, game over
- [Flappy bird font](https://www.dafont.com/04b-19.font) - score font
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
