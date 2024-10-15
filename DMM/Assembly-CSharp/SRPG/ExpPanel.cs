// Decompiled with JetBrains decompiler
// Type: SRPG.ExpPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20023AA")]
  [FlowNode.Pin(100, "Level Up", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/ExpPanel")]
  public class ExpPanel : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A111")]
    [FieldOffset(Offset = "0xC")]
    public Text Level;
    [Token(Token = "0x400A112")]
    [FieldOffset(Offset = "0x10")]
    public Text LevelMax;
    [Token(Token = "0x400A113")]
    [FieldOffset(Offset = "0x14")]
    public Text ValueCurrent;
    [Token(Token = "0x400A114")]
    [FieldOffset(Offset = "0x18")]
    public Text ValueCurrentInLv;
    [Token(Token = "0x400A115")]
    [FieldOffset(Offset = "0x1C")]
    public Text ValueLeft;
    [Token(Token = "0x400A116")]
    [FieldOffset(Offset = "0x20")]
    public Text ValueTotal;
    [Token(Token = "0x400A117")]
    [FieldOffset(Offset = "0x24")]
    public Slider LevelSlider;
    [Token(Token = "0x400A118")]
    [FieldOffset(Offset = "0x28")]
    public Slider ExpSlider;
    [Token(Token = "0x400A119")]
    [FieldOffset(Offset = "0x2C")]
    public float ExpAnimLength;
    [Token(Token = "0x400A11A")]
    [FieldOffset(Offset = "0x30")]
    private int mCurrentExp;
    [Token(Token = "0x400A11B")]
    [FieldOffset(Offset = "0x34")]
    private float mExpStart;
    [Token(Token = "0x400A11C")]
    [FieldOffset(Offset = "0x38")]
    private float mExpEnd;
    [Token(Token = "0x400A11D")]
    [FieldOffset(Offset = "0x3C")]
    private float mExpAnimTime;
    [Token(Token = "0x400A11E")]
    [FieldOffset(Offset = "0x40")]
    private int mLevelCap;
    [Token(Token = "0x400A11F")]
    [FieldOffset(Offset = "0x44")]
    private ExpPanel.CalcEvent mOnCalcExp;
    [Token(Token = "0x400A120")]
    [FieldOffset(Offset = "0x48")]
    private ExpPanel.CalcEvent mOnCalcLevel;
    [Token(Token = "0x400A121")]
    [FieldOffset(Offset = "0x4C")]
    public ExpPanel.LevelChangeEvent OnLevelChange;
    [Token(Token = "0x400A122")]
    [FieldOffset(Offset = "0x50")]
    public ExpPanel.ExpPanelEvent OnFinish;

    [Token(Token = "0x17001571")]
    public bool IsBusy
    {
      [Token(Token = "0x6009A59"), Address(RVA = "0x5E87C0", Offset = "0x5E75C0", VA = "0x105E87C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001572")]
    public int Exp
    {
      [Token(Token = "0x6009A5A"), Address(RVA = "0x5E87E0", Offset = "0x5E75E0", VA = "0x105E87E0")] set
      {
      }
      [Token(Token = "0x6009A5B"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001573")]
    public int LevelCap
    {
      [Token(Token = "0x6009A5C"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009A5D"), Address(RVA = "0x5E8830", Offset = "0x5E7630", VA = "0x105E8830")] set
      {
      }
    }

    [Token(Token = "0x6009A5E")]
    [Address(RVA = "0x5E7F50", Offset = "0x5E6D50", VA = "0x105E7F50")]
    public void AnimateTo(int newExp)
    {
    }

    [Token(Token = "0x6009A5F")]
    [Address(RVA = "0x5E84A0", Offset = "0x5E72A0", VA = "0x105E84A0")]
    public void Stop()
    {
    }

    [Token(Token = "0x6009A60")]
    [Address(RVA = "0x5E7FE0", Offset = "0x5E6DE0", VA = "0x105E7FE0")]
    public void SetDelegate(ExpPanel.CalcEvent expFromLv, ExpPanel.CalcEvent lvFromExp)
    {
    }

    [Token(Token = "0x6009A61")]
    [Address(RVA = "0x5E8010", Offset = "0x5E6E10", VA = "0x105E8010")]
    private void SetValues(float exp)
    {
    }

    [Token(Token = "0x6009A62")]
    [Address(RVA = "0x5E7D80", Offset = "0x5E6B80", VA = "0x105E7D80")]
    private void AnimateExp(float dt)
    {
    }

    [Token(Token = "0x6009A63")]
    [Address(RVA = "0x5E84C0", Offset = "0x5E72C0", VA = "0x105E84C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009A64")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009A65")]
    [Address(RVA = "0x5E8500", Offset = "0x5E7300", VA = "0x105E8500")]
    public ExpPanel()
    {
    }

    [Token(Token = "0x20023AB")]
    public delegate int CalcEvent(int value);

    [Token(Token = "0x20023AC")]
    public delegate void LevelChangeEvent(int levelOld, int levelNew);

    [Token(Token = "0x20023AD")]
    public delegate void ExpPanelEvent();
  }
}
