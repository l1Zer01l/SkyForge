cmake_minimum_required(VERSION 3.28 FATAL_ERROR)


set(PROPERTY_NAME SkyForge)
set(EXAMPLE_PROPERTY_NAME ExampleGame)

project(${PROPERTY_NAME} VERSION 0.0.1 LANGUAGES CSharp)

add_library(${PROPERTY_NAME} SHARED
	src/SkyForge/Core/Application.cs
	src/SkyForge/Core/EntryPoint.cs
	src/SkyForge/Math/Vector2.cs
	src/SkyForge/GameComponent/IComponent.cs
	src/SkyForge/GameComponent/BaseComponent.cs
	src/SkyForge/IGameObject.cs
	src/SkyForge/GameObject.cs

)

add_executable(${EXAMPLE_PROPERTY_NAME}
	src/ExampleGame/Game.cs
	src/ExampleGame/ExampleGame.cs
	src/ExampleGame/Player.cs
)

target_link_libraries(${EXAMPLE_PROPERTY_NAME} PRIVATE ${PROPERTY_NAME}) 

