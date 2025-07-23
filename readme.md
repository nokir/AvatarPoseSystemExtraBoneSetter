# APSEB Setter (Avatar Pose System Extra Bone Setter)

## 概要 (Overview)

このツールは、Unityエディタ上で選択したGameObjectに`AvatarPoseSystemExtraBone`コンポーネントを簡単に追加・設定するためのエディタ拡張です。
`VRCPhysBone`が設定されているGameObjectに対して、その`rootTransform`を`AvatarPoseSystemExtraBone`の`rootTransform`に自動で設定します。

This tool is a Unity Editor extension that simplifies adding and configuring the `AvatarPoseSystemExtraBone` component to selected GameObjects.
For GameObjects that have a `VRCPhysBone` component, it automatically sets the `rootTransform` of the `AvatarPoseSystemExtraBone` to match the `rootTransform` of the `VRCPhysBone`.

## 使い方 (Usage)

1.  Unityエディタのヒエラルキー(Hierarchy)で、`VRCPhysBone`コンポーネントを持つGameObjectを選択します。
2.  メニューバーから `Tools > N > APSEB Setter` を選択します。
3.  選択したGameObjectに`AvatarPoseSystemExtraBone`コンポーネントが追加（または既存のものが利用）され、`rootTransform`が自動で設定されます。

1.  In the Unity Editor's Hierarchy, select the GameObject(s) that have a `VRCPhysBone` component.
2.  From the menu bar, select `Tools > N > APSEB Setter`.
3.  The `AvatarPoseSystemExtraBone` component will be added (or an existing one will be used) to the selected GameObject(s), and its `rootTransform` will be automatically configured.

## 依存関係 (Dependencies)

-   VRChat SDK (for `VRCPhysBone`)
-   Avatar Pose System (for `AvatarPoseSystemExtraBone`)