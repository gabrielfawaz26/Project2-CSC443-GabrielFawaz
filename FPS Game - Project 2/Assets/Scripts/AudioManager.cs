using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxSource;

    [Header("SFX")]
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private AudioClip reloadSound;
    [SerializeField] private AudioClip changeweaponSound;
    [SerializeField] private AudioClip hitSound;
    [SerializeField] private AudioClip healsound;
    [SerializeField] private AudioClip ammosound;
    [SerializeField] private AudioClip deathsound;

    [Header("Click")]
    [SerializeField] private AudioClip buttonClickSound;

    private void OnEnable()
    {
        GAME_EVENTS.OnShoot += PlayShoot;
        GAME_EVENTS.OnReload += PlayReload;
        GAME_EVENTS.OnChangeWeapon += PlayChangeWeapon;
        GAME_EVENTS.OnHit += PlayHit;
        GAME_EVENTS.OnHeal += PlayHeal;
        GAME_EVENTS.OnAmmo += PlayAmmo;
        GAME_EVENTS.OnDead += PlayDead;
    }

    private void OnDisable()
    {
        GAME_EVENTS.OnShoot -= PlayShoot;
        GAME_EVENTS.OnReload -= PlayReload;
        GAME_EVENTS.OnChangeWeapon -= PlayChangeWeapon;
        GAME_EVENTS.OnHit -= PlayHit;
        GAME_EVENTS.OnHeal -= PlayHeal;
        GAME_EVENTS.OnAmmo -= PlayAmmo;
        GAME_EVENTS.OnDead -= PlayDead;
    }

    void PlayShoot() => sfxSource.PlayOneShot(shootSound);
    void PlayReload() => sfxSource.PlayOneShot(reloadSound);
    void PlayChangeWeapon() => sfxSource.PlayOneShot(changeweaponSound);
    void PlayHit() => sfxSource.PlayOneShot(hitSound);
    void PlayHeal() => sfxSource.PlayOneShot(healsound);
    void PlayAmmo() => sfxSource.PlayOneShot(ammosound);
    void PlayDead() => sfxSource.PlayOneShot(deathsound);

    public void PlayButtonClick()
    {
        sfxSource.PlayOneShot(buttonClickSound);
    }

}
