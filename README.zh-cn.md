# 摄像机跟随角色控制器

[English](https://github.com/make-game-modules/camera-follow-character-controller/blob/main/README.en.md)

这个项目提供了一个 Unity 脚本，可以使摄像机平滑地跟随角色的移动。此脚本需要挂载在摄像机上。

## 如何安装

在 Unity 项目中，任意位置使用 git clone 本仓库即可。

## 如何使用

1. 将此脚本挂载到主摄像机上。
2. 在 Unity 编辑器中设置脚本的 public 属性。

## 参数设置

- `playerTransform`: 需要跟随的角色的 Transform 组件。在 Unity 编辑器中设置这个属性，使其指向角色的 Transform 组件。
- `smoothSpeed`: 控制摄像机移动平滑度的参数。值越大，摄像机跟随角色的速度越快，反之则越慢。
- `offset`: 摄像机相对于角色的偏移量。在 Unity 编辑器中设置这个属性，以控制摄像机的视角。

## 运行原理

在每一次物理更新时，脚本会计算出摄像机的目标位置，并使用 Lerp 函数平滑地移动摄像机，实现平滑跟随角色的效果。

## 版权信息

本项目采用 MIT 开源许可证，欢迎任何人对项目的改进和使用。
