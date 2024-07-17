using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DPad : MonoBehaviour
{
    public static bool Jump { get; private set; }
    public static bool Slide { get; private set; }
    public static float Horizontal { get; private set; }
    public static float Direction;
    public static bool Attack { get; private set; }
    public static bool Throw { get; private set; }
    [SerializeField] Button BtnUp, BtnDown, BtnLeft, BtnRight, BtnAttack, BtnThrow;

    [SerializeField] PlayerController controller;
    // Start is called before the first frame update
    void Start()
    {
        BtnUp.onClick.AddListener(OnClickJump);
        BtnDown.onClick.AddListener(OnclickDown);
        BtnLeft.onClick.AddListener(() => OnclickHorizontal(-1));
        BtnRight.onClick.AddListener(() => OnclickHorizontal(1));

        BtnAttack.onClick.AddListener(OnClickAttack);
        BtnThrow.onClick.AddListener(OnClickThrow);
    }

    void Update()
    {
        Jump = false;
        Slide = false;
        Horizontal = 0f;
        Attack = false;
        Throw = false;
    }

    private void OnClickJump()
    {
        Jump = true;
    }

    private void OnclickDown()
    {
        Slide = true;
    }

    private void OnclickHorizontal(float direction)
    {
        Horizontal = direction;
        Direction = direction;
    }
    private void OnClickAttack()
    {
        Attack = true;
    }
    private void OnClickThrow()
    {
        Throw = true;
    }

    public static bool GetButtonJump()
    {
        return Jump;
    }
    public static bool GetButtonSlide()
    {
        return Slide;
    }
    public static float GetHorizontalInput()
    {
        return Horizontal;
    }
    public static bool GetButtonAttack()
    {
        return Attack;
    }
    public static bool GetButtonThrow()
    {
        return Throw;
    }
}
