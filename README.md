# Terrain-generation #

## References, Reasons and Goals ##
Using noise to generate terrains. May be expanded to generate planets.

The terrain generation project follows the tutorials from Sebastian Lague:
https://www.youtube.com/user/Cercopithecan

Goals for the project:

* Re-introduction to unity
* Further understanding of C#
* Further understanding of terrain generation

Lague's tutorials provide succinct ideas of how code should be laid out in a clear and efficient manner. The tutorials appear to draw a large amount from Unity's documentation if any additional explanation of functions or formatting is required:
https://docs.unity3d.com/ScriptReference/Mathf.PerlinNoise.html

## Task List ##

The following list comprises a general layout of the goals of the project, in-line with the tutorials being followed with some additional goals of my own. Sub tasks will be added as stages are reached. Dropped tasks will remain with a ~~strikethrough~~.

- [ ] Generate noise
  - [x] Generate 2D black and white texture
  - [ ] Implement lacunarity and persistence
  - [ ] Implement octaves
  - [ ] Add colour regions to the noise
  - [ ] Add falloff map
- [ ] Display texture
  - [x] Add editor functions to change parameters
- [ ] Generate mesh
  - [ ] Use noise map as height map
  - [ ] Level of Detail (LoD) function
  - [ ] Implement chunks/endless terrain
  - [ ] Add collision mesh
  - [ ] Fix seams

## Code Structure ##

_Will be added at a later stage_
