// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidTrainingScrollablePulldown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002594")]
  public class GuildRaidTrainingScrollablePulldown : ScrollablePulldownCustom
  {
    [Token(Token = "0x400AE60")]
    [FieldOffset(Offset = "0x104")]
    public GuildRaidTrainingScrollablePulldown.SelectSelfEvent OnTapPullDown;

    [Token(Token = "0x600A6EE")]
    [Address(RVA = "0x68DA50", Offset = "0x68C850", VA = "0x1068DA50", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600A6EF")]
    [Address(RVA = "0x68DAA0", Offset = "0x68C8A0", VA = "0x1068DAA0")]
    private void SetVerticalPosScrollItem()
    {
    }

    [Token(Token = "0x600A6F0")]
    [Address(RVA = "0x6620D0", Offset = "0x660ED0", VA = "0x106620D0")]
    public GuildRaidTrainingScrollablePulldown()
    {
    }

    [Token(Token = "0x2002595")]
    public delegate void SelectSelfEvent(bool value);
  }
}
