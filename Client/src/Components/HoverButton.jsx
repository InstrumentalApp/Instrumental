/* eslint-disable react/prop-types */
import styles from "../Styles/App";
import { Link } from "react-router-dom";

const HoverButton = ({
  children,
  onClick = null,
  link = null,
  backgroundColor = styles.colors.PRIMARY,
  color = "white",
  fontSize = "15px",
  fontWeight = "normal",
  borderRadius = "50px",
  shadow = "4px 4px 0",
  padding = "10px 20px",
  margin = "0",
  style,
  ...rest}) =>
{

  const buttonStyle = {
    padding: padding,
    margin: margin,
    boxShadow: `${shadow} black`,
    color: color,
    backgroundColor: backgroundColor,
    border: "2.5px solid black",
    borderRadius: borderRadius,
    fontSize: fontSize,
    fontWeight: fontWeight,
    letterSpacing: "1px",
    transition: "translate .2s, box-shadow .25s",
  };

  // This will create the effect
  const hoverStyle = {
    translate: shadow,
    boxShadow: "none", 
  };
  
  const handleMouseOver = (e) => {
    e.currentTarget.style.translate = hoverStyle.translate;
    e.currentTarget.style.boxShadow = hoverStyle.boxShadow;
  }

  const handleMouseOut = (e) => {
    e.currentTarget.style.translate = "0 0 0";
    e.currentTarget.style.boxShadow = `${shadow} black`;
  }

  return (
    <Link to={link}>
      <button
        {...rest}
        style={{ ...buttonStyle, ...(style || {}) }}
        onMouseOver={(e) =>
          handleMouseOver(e)
        }
        onMouseOut={(e) =>
          handleMouseOut(e)
        }
        onClick={onClick}
      >
        {children}
      </button>
    </Link>
  )
}

export default HoverButton;