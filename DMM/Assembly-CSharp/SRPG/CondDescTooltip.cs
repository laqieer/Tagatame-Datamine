// Decompiled with JetBrains decompiler
// Type: SRPG.CondDescTooltip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E21")]
  [AddComponentMenu("Battle/UnitDetail/CondDescTooltip")]
  public class CondDescTooltip : MonoBehaviour
  {
    [Token(Token = "0x4002ACB")]
    [FieldOffset(Offset = "0xC")]
    public CondDescTooltip.eDispType DispType;
    [Token(Token = "0x4002ACC")]
    [FieldOffset(Offset = "0x10")]
    public Tooltip PrefabTooltip;
    [Token(Token = "0x4002ACD")]
    [FieldOffset(Offset = "0x14")]
    public ImageArray ImageCond;
    [Token(Token = "0x4002ACE")]
    [FieldOffset(Offset = "0x18")]
    public float PosLeftOffset;
    [Token(Token = "0x4002ACF")]
    [FieldOffset(Offset = "0x1C")]
    public float PosRightOffset;
    [Token(Token = "0x4002AD0")]
    [FieldOffset(Offset = "0x20")]
    public float PosUpOffset;
    [Token(Token = "0x4002AD1")]
    [FieldOffset(Offset = "0x0")]
    private static Tooltip mTooltip;
    [Token(Token = "0x4002AD2")]
    [FieldOffset(Offset = "0x24")]
    private CanvasGroup[] mParentCgs;

    [Token(Token = "0x6003A31")]
    [Address(RVA = "0x10DA4C0", Offset = "0x10D92C0", VA = "0x110DA4C0")]
    private void Start()
    {
    }

    [Token(Token = "0x17000427")]
    private CanvasGroup[] ParentCgs
    {
      [Token(Token = "0x6003A32"), Address(RVA = "0x10DA680", Offset = "0x10D9480", VA = "0x110DA680")] get
      {
        return (CanvasGroup[]) null;
      }
    }

    [Token(Token = "0x6003A33")]
    [Address(RVA = "0x10D9D60", Offset = "0x10D8B60", VA = "0x110D9D60")]
    private void ShowTooltip(PointerEventData event_data)
    {
    }

    [Token(Token = "0x6003A34")]
    [Address(RVA = "0x10D88B0", Offset = "0x10D76B0", VA = "0x110D88B0")]
    private IEnumerator ResetPosiotion() => (IEnumerator) null;

    [Token(Token = "0x6003A35")]
    [Address(RVA = "0x10D8920", Offset = "0x10D7720", VA = "0x110D8920")]
    private string SetSkillDistanceText(string desc) => (string) null;

    [Token(Token = "0x6003A36")]
    [Address(RVA = "0x10DA650", Offset = "0x10D9450", VA = "0x110DA650")]
    public CondDescTooltip()
    {
    }

    [Token(Token = "0x2000E22")]
    public enum eDispType
    {
      [Token(Token = "0x4002AD4")] LEFT,
      [Token(Token = "0x4002AD5")] RIGHT,
      [Token(Token = "0x4002AD6")] UP,
    }
  }
}
