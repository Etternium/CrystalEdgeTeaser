using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Cinemachine;
using DG.Tweening;

public class TimelineSignals : MonoBehaviour
{
    public void Timeline_MoveMaskLeft(GameObject mask)
    {
        Vector3 startPos = mask.transform.position;
        float x = startPos.x - 1;
        float y = startPos.x - 3;
        mask.transform.DOMoveX(y, 3.5f).SetEase(Ease.OutExpo);
        //    .OnComplete(() =>
        //{
        //    mask.transform.DOMoveX(y, 3f);
        //});
    }

    public void Timeline_MoveMaskRight(GameObject mask)
    {
        Vector3 startPos = mask.transform.position;
        float x = startPos.x + 1;
        float y = startPos.x + 3;
        mask.transform.DOMoveX(y, 3.5f).SetEase(Ease.OutExpo);
        //    .OnComplete(() =>
        //{
        //    mask.transform.DOMoveX(y, 3f);
        //});
    }

    public void Timeline_PlayVFX(ParticleSystem vfx)
    {
        vfx.Play();
    }

    public void Timeline_PlayTrailRenderer(TrailRenderer trailRenderer)
    {
        float x = trailRenderer.transform.position.x;
        float y = -13.03f;
        Vector3 endPos = new Vector3(-x, y, 5);
        trailRenderer.transform.DOMove(endPos, .2f);
    }

    public void Timeline_ScreenFlash(Image image)
    {
        image.DOFade(1f, .1f).SetLoops(2, LoopType.Yoyo);
    }

    public void Timeline_TextDisplay(TMP_Text text)
    {
        Vector3 endValue = Vector3.one * 1.25f;

        text.DOFade(1f, 2f).SetEase(Ease.OutSine);
        text.transform.DOScale(endValue, 5f).SetEase(Ease.OutSine);
    }

    public void Timeline_TextFadeout(TMP_Text text)
    {
        text.DOFade(0f, 1f).SetEase(Ease.OutSine);
    }

    public void Timeline_ImageFadeOut(Image image) => image.DOFade(1, 2.5f);
    public void Timeline_ImageFadeIn(Image image) => image.DOFade(0, 1.5f);

    public void Timeline_ScreenShake(CinemachineImpulseSource source)
    {
        source.GenerateImpulse();
    } 
}
