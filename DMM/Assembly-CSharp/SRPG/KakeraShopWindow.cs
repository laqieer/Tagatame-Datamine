// Decompiled with JetBrains decompiler
// Type: SRPG.KakeraShopWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002672")]
  [FlowNode.Pin(100, "完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "魂の欠片に変換", FlowNode.PinTypes.Input, 10)]
  [AddComponentMenu("UI/KakeraShopWindow")]
  public class KakeraShopWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x600ABA0")]
    [Address(RVA = "0x6EB4A0", Offset = "0x6EA2A0", VA = "0x106EB4A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ABA1")]
    [Address(RVA = "0x6EB650", Offset = "0x6EA450", VA = "0x106EB650")]
    private void OnConvert()
    {
    }

    [Token(Token = "0x600ABA2")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public KakeraShopWindow()
    {
    }
  }
}
