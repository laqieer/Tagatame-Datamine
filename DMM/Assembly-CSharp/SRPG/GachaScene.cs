// Decompiled with JetBrains decompiler
// Type: SRPG.GachaScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F23")]
  [AddComponentMenu("Common/GachaScene")]
  [FlowNode.Pin(100, "表示開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "終了", FlowNode.PinTypes.Input, 10)]
  public class GachaScene : SceneRoot, IFlowInterface
  {
    [Token(Token = "0x4002F2B")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Result2D;
    [Token(Token = "0x4002F2C")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Result3D;
    [Token(Token = "0x4002F2D")]
    [FieldOffset(Offset = "0x14")]
    public GridLayoutGroup GridLayout;
    [Token(Token = "0x4002F2E")]
    [FieldOffset(Offset = "0x18")]
    public int MaxGridColumnCount;
    [Token(Token = "0x4002F2F")]
    [FieldOffset(Offset = "0x1C")]
    public string[] PreviewUnitID;
    [Token(Token = "0x4002F30")]
    [FieldOffset(Offset = "0x20")]
    public string[] PreviewItemID;
    [Token(Token = "0x4002F31")]
    [FieldOffset(Offset = "0x24")]
    private GachaScene.DropClasses mDropClass;
    [Token(Token = "0x4002F32")]
    [FieldOffset(Offset = "0x28")]
    private string[] mDropID;
    [Token(Token = "0x4002F33")]
    [FieldOffset(Offset = "0x2C")]
    private bool mDropSet;

    [Token(Token = "0x6003F30")]
    [Address(RVA = "0x1178A60", Offset = "0x1177860", VA = "0x11178A60", Slot = "5")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6003F31")]
    [Address(RVA = "0x1178B80", Offset = "0x1177980", VA = "0x11178B80")]
    public void DropUnits(string[] unitID)
    {
    }

    [Token(Token = "0x6003F32")]
    [Address(RVA = "0x1178B50", Offset = "0x1177950", VA = "0x11178B50")]
    public void DropItems(string[] itemID)
    {
    }

    [Token(Token = "0x6003F33")]
    [Address(RVA = "0x1178B40", Offset = "0x1177940", VA = "0x11178B40", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6003F34")]
    [Address(RVA = "0x1178C20", Offset = "0x1177A20", VA = "0x11178C20")]
    private void Start()
    {
    }

    [Token(Token = "0x6003F35")]
    [Address(RVA = "0x1178AD0", Offset = "0x11778D0", VA = "0x11178AD0")]
    private IEnumerator AsyncUpdate() => (IEnumerator) null;

    [Token(Token = "0x6003F36")]
    [Address(RVA = "0x1178BB0", Offset = "0x11779B0", VA = "0x11178BB0")]
    private IEnumerator ExitGachaAsync() => (IEnumerator) null;

    [Token(Token = "0x6003F37")]
    [Address(RVA = "0x1178CF0", Offset = "0x1177AF0", VA = "0x11178CF0")]
    public GachaScene()
    {
    }

    [Token(Token = "0x2000F24")]
    public enum DropClasses
    {
      [Token(Token = "0x4002F35")] Unit,
      [Token(Token = "0x4002F36")] Item,
    }
  }
}
