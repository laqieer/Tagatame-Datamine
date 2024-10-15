// Decompiled with JetBrains decompiler
// Type: SRPG.PrimitiveParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010B7")]
  [AddComponentMenu("Common/PrimitiveParameter")]
  public class PrimitiveParameter : MonoBehaviour, IGameParameter
  {
    [Token(Token = "0x4003BFF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private PrimitiveParameter.PrimitiveType Type;
    [Token(Token = "0x4003C00")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TargetText;

    [Token(Token = "0x60046D0")]
    [Address(RVA = "0x11E2EB0", Offset = "0x11E1CB0", VA = "0x111E2EB0", Slot = "4")]
    public void UpdateValue()
    {
    }

    [Token(Token = "0x60046D1")]
    [Address(RVA = "0x11E2E30", Offset = "0x11E1C30", VA = "0x111E2E30")]
    private void SetText(string text)
    {
    }

    [Token(Token = "0x60046D2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public PrimitiveParameter()
    {
    }

    [Token(Token = "0x20010B8")]
    public enum PrimitiveType
    {
      [Token(Token = "0x4003C02")] Int,
      [Token(Token = "0x4003C03")] Long,
      [Token(Token = "0x4003C04")] Float,
      [Token(Token = "0x4003C05")] Double,
      [Token(Token = "0x4003C06")] String,
    }
  }
}
