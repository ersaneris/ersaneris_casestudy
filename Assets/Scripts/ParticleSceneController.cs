using UnityEngine;

public class ParticleSceneController : MonoBehaviour
{
    public ParticleSystem CurrentParticle;
    public SpriteRenderer GiantPinataSpriteRenderer;

    private int _state;
    public void OnPlayClick()
    {
        _state = ++_state%2;
        switch (_state)
        {
            case 0:
                CurrentParticle.Stop(true);
                CurrentParticle.gameObject.SetActive(false);
                GiantPinataSpriteRenderer.enabled = true;
                break;
            case 1:
                CurrentParticle.gameObject.SetActive(true);
                CurrentParticle.Play(true);
                GiantPinataSpriteRenderer.enabled = false;
                break;
        }
    }
}
